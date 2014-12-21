package com.example.friendstouch;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.List;

import org.apache.http.HttpResponse;
import org.apache.http.NameValuePair;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.entity.UrlEncodedFormEntity;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.message.BasicNameValuePair;

import com.example.friendstouch.util.TouchHelper;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MakeNewComment extends Activity implements OnClickListener {

	private final String COMMENT_POST_STRING = "http://friendtouch.apphb.com/api/services/postcomment";

	private EditText textMessage;
	private Button btn_Send;

	private ArrayList<NameValuePair> bodyToSend;
	private String postId;
	private HttpPostComment mHttpPostComment;

	private Context context = this;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.new_comment);

		bodyToSend = new ArrayList<NameValuePair>();

		Intent intent = getIntent();
		postId = intent.getStringExtra("PostId");

		btn_Send = (Button) findViewById(R.id.btn_sendPictureComment);
		textMessage = (EditText) findViewById(R.id.message);

		btn_Send.setOnClickListener(this);
	}

	public void onClick(View v) {
		String msgComment = this.textMessage.getText().toString();

		if (!msgComment.matches("")) {
			this.bodyToSend.add(new BasicNameValuePair("postid", postId));
			this.bodyToSend.add(new BasicNameValuePair("text", msgComment));

			this.mHttpPostComment = new HttpPostComment(COMMENT_POST_STRING,
					this.bodyToSend);
			this.mHttpPostComment.execute();
		}

		super.onBackPressed();
	}

	class HttpPostComment extends AsyncTask<Void, Void, String> {

		private List<NameValuePair> mData;
		private String connection;

		public HttpPostComment(String connection, ArrayList<NameValuePair> data) {
			this.connection = connection;
			this.mData = data;
		}

		@Override
		protected String doInBackground(Void... params) {
			if (TouchHelper.isOnline(context)) {
				if (!mHttpPostComment.isCancelled()) {

					HttpClient client = new DefaultHttpClient();
					HttpPost post = new HttpPost(this.connection);

					String bearer = "Bearer " + TouchHelper.getToken(context);

					// post.addHeader("Accept", "aplication/json");
					post.addHeader("Authorization", bearer);

					InputStream inputStream;
					HttpResponse response;
					InputStreamReader inputReader = null;

					try {
						post.setEntity(new UrlEncodedFormEntity(this.mData));
						response = client.execute(post);
						StringBuilder sb = new StringBuilder();
						if (response != null) {
							inputStream = response.getEntity().getContent();
							inputReader = new InputStreamReader(inputStream);
							BufferedReader bufferedReader = new BufferedReader(
									inputReader);

							String chunk;

							while ((chunk = bufferedReader.readLine()) != null) {
								sb.append(chunk);
							}
						}
						return sb.toString();
						// Log.d("D1", sb.toString());
					} catch (UnsupportedEncodingException e) {
						return e.getMessage().toString();
					} catch (ClientProtocolException e) {
						return e.getMessage().toString();
					} catch (IOException e) {
						return e.getMessage().toString();
					} finally {
						client.getConnectionManager().shutdown();
						try {
							inputReader.close();
						} catch (IOException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
					}
				}
			}

			return "No connection";
		}

		@Override
		protected void onPostExecute(String result) {
			super.onPostExecute(result);
			if (!result.matches("No connection")) {
				Toast.makeText(context, "You have commented this post",
						Toast.LENGTH_LONG).show();

				Intent intent = new Intent(context, ActivityMainScreen.class);
				startActivity(intent);
			}else {
				Toast.makeText(context, result,
						Toast.LENGTH_LONG).show();
			}
		}

		@Override
		protected void onPreExecute() {
			super.onPreExecute();
		}

	}
}
