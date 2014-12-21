package com.example.friendstouch;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import android.R.integer;
import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.Button;
import android.widget.ListView;
import android.widget.ProgressBar;
import android.widget.Toast;

import com.example.friendstouch.util.TouchHelper;

public class ActivityMainScreen extends Activity implements OnClickListener {

	private final String GET_POST_CONNECTION = "http://friendtouch.apphb.com/api/services/getposts";

	private Button btn_TakePhoto;
	private HttpGetPosts getPosts;

	private ProgressBar mLoading;
	private ListView list;

	private final ArrayList<Record> data = new ArrayList<Record>();
	private Context context = this;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main_activity_screen);

		this.mLoading = (ProgressBar) findViewById(R.id.iLoader);
		this.mLoading.setVisibility(View.INVISIBLE);

		this.btn_TakePhoto = (Button) findViewById(R.id.btn_newRecord);
		this.btn_TakePhoto.setOnClickListener(this);

		this.list = (ListView) findViewById(R.id.listViewMain);
	}

	@Override
	public void onClick(View v) {
		Intent myIntent = new Intent(v.getContext(), MyCameraActivity.class);
		startActivityForResult(myIntent, 0);
	}

	@Override
	protected void onDestroy() {
		super.onDestroy();
		this.getPosts.cancel(true);
	}

	@Override
	protected void onResume() {
		super.onResume();
		data.clear();
		this.getPosts = new HttpGetPosts();
		this.getPosts.execute(GET_POST_CONNECTION);

	}

	private class HttpGetPosts extends AsyncTask<String, Void, String> {
		private final String TOKEN = "Bearer " + TouchHelper.getToken(context);

		@Override
		protected String doInBackground(String... params) {
			if (TouchHelper.isOnline(context)) {
				if (!getPosts.isCancelled()) {
					HttpClient client = new DefaultHttpClient();
					HttpGet get = new HttpGet(params[0]);

					get.addHeader("Authorization", TOKEN);
					get.addHeader("Accept", "aplication/json");

					InputStream inputStream;
					HttpResponse response;
					InputStreamReader inputReader;
					HttpEntity httpEntity;
					try {
						response = client.execute(get);
						StringBuilder sb = new StringBuilder();
						if (response != null) {
							httpEntity = response.getEntity();
							inputStream = httpEntity.getContent();
							inputReader = new InputStreamReader(inputStream);
							BufferedReader bufferedReader = new BufferedReader(
									inputReader);
							String chunk;

							while ((chunk = bufferedReader.readLine()) != null) {
								sb.append(chunk);
							}

						}
						
						Log.d("Recieved", sb.toString());
						return sb.toString();
					} catch (Exception e) {
						e.printStackTrace();
					}
				}
			}
			
			return "No connection";

		}

		@Override
		protected void onPostExecute(String result) {
			super.onPostExecute(result);
			if (!result.matches("No connection")) {
				fillRecievedData(result);

				RecordAdapter adapter = new RecordAdapter(context,
						R.layout.list_view, data);

				list.setAdapter(adapter);

				list.setOnItemClickListener(new OnItemClickListener() {
					@Override
					public void onItemClick(AdapterView<?> parent, View view,
							int position, long id) {
						Intent newCommentIntent = new Intent(view.getContext(),
								ActivityRecordDetails.class);
						newCommentIntent.putExtra("data", data.get(position));
						startActivityForResult(newCommentIntent, 0);
					}
				});
			}else{

				Toast.makeText(context, result, Toast.LENGTH_LONG).show();
			}
			
			mLoading.setVisibility(View.INVISIBLE);
			list.setVisibility(View.VISIBLE);

		}

		@Override
		protected void onPreExecute() {
			super.onPreExecute();
			list.setVisibility(View.INVISIBLE);
			mLoading.setVisibility(View.VISIBLE);
		}

		private void fillRecievedData(String result) {
			if (result != null) {
				try {
					JSONArray resultData = new JSONArray(result);

					String image, dateCreated, longitude, latitude, description, publisher;
					int commentId = 0;

					for (int i = 0; i < resultData.length(); i++) {
						JSONObject currentPost = resultData.getJSONObject(i);
						commentId = Integer.parseInt(currentPost
								.getString("Id"));
						image = currentPost.getString("Image");
						dateCreated = currentPost.getString("DateCreated");
						longitude = currentPost.getString("Longitude");
						latitude = currentPost.getString("Latitude");
						description = currentPost.getString("Description");
						publisher = currentPost.getString("Publisher");
						Record currentRecord = new Record(commentId, publisher,
								description, image, dateCreated, latitude,
								longitude);

						JSONArray commentsData = currentPost
								.getJSONArray("Comment");
						if (commentsData.length() != 0) {
							for (int j = 0; j < commentsData.length(); j++) {

								String owner = commentsData.getJSONObject(j)
										.getString("Author");
								String message = commentsData.getJSONObject(j)
										.getString("Text");
								String date = commentsData.getJSONObject(j)
										.getString("DateCreated");

								currentRecord.setComments(new Comment(owner,
										message, date));
							}
						} else {
							currentRecord.setComments(new Comment("",
									"BE THE FIRST TO COMMENT...", ""));
						}

						data.add(currentRecord);
					}

				} catch (JSONException e) {
					e.printStackTrace();
				}
			}
		}
	}
}