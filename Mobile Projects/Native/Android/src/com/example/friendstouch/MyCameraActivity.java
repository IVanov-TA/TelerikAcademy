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

import android.app.Activity;
import android.app.SearchManager.OnCancelListener;
import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.location.Location;
import android.location.LocationManager;
import android.os.AsyncTask;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.Toast;

import com.example.friendstouch.util.TouchHelper;

public class MyCameraActivity extends Activity implements OnCancelListener,
		OnClickListener {

	private static final int REQUEST_IMAGE_CAPTURE = 1;
	private static final String POST_TOUCH_CONNECTION = "http://friendtouch.apphb.com/api/services/posttouch";
	public Button mBtn_MakePost;
	public ImageView newImage;
	private Bitmap imageBitmap;
	private EditText mTextDescription;
	private ProgressBar mLoading;

	private String mLatitude;
	private String mLongitude;

	private ArrayList<NameValuePair> data;

	private Context context = this;

	private HttpPostRegister httpRegister;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.new_record);

		this.mBtn_MakePost = (Button) findViewById(R.id.btnPost);
		this.mTextDescription = (EditText) findViewById(R.id.message);
		this.mLoading = (ProgressBar) findViewById(R.id.iPostLoader);

		LocationManager manager = (LocationManager) getSystemService(Context.LOCATION_SERVICE);
		Location location = manager
				.getLastKnownLocation(LocationManager.NETWORK_PROVIDER);

		if (location == null) {
			this.mLatitude = "none";
			this.mLongitude = "none";
			Toast.makeText(this.getApplicationContext(),
					"Location unavailable", Toast.LENGTH_LONG);
		} else {
			this.mLatitude = String.valueOf(location.getLatitude());
			this.mLongitude = String.valueOf(location.getLongitude());
			// t = Toast.makeText(this.getApplicationContext(),
			// "Latitude: "+location.getLatitude() + "\n " +
			// "Longitude: " + location.getLongitude(), Toast.LENGTH_LONG);
		}

		mBtn_MakePost.setEnabled(false);
		mBtn_MakePost.setOnClickListener(this);

		dispatchTakePictureIntent();
	}

	private void dispatchTakePictureIntent() {
		Intent takePictureIntent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
		if (takePictureIntent.resolveActivity(getPackageManager()) != null) {
			startActivityForResult(takePictureIntent, REQUEST_IMAGE_CAPTURE);
		}
	}

	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {
		if (requestCode == REQUEST_IMAGE_CAPTURE && resultCode == RESULT_OK) {
			Bundle extras = data.getExtras();
			imageBitmap = (Bitmap) extras.get("data");

			ImageView newPicture = (ImageView) findViewById(R.id.showImg);
			newPicture.setImageBitmap(imageBitmap);

			mBtn_MakePost.setEnabled(true);
		}
	}

	@Override
	public void onCancel() {
	}

	@Override
	protected void onResume() {
		super.onResume();
		this.mLoading.setVisibility(View.INVISIBLE);
	}

	@Override
	public void onClick(View v) {
		if (imageBitmap != null) {
			if (this.mTextDescription.getText().toString().matches("")) {
				// TODO Make DialogBox YES NO MSG"Post without description?"
			}

			this.data = new ArrayList<NameValuePair>();
			this.data.add(new BasicNameValuePair("Description",
					this.mTextDescription.getText().toString()));
			this.data.add(new BasicNameValuePair("Longitude", this.mLongitude));
			this.data.add(new BasicNameValuePair("Latitude", this.mLatitude));
			this.data.add(new BasicNameValuePair("Image", TouchHelper
					.BitMapToString(this.imageBitmap)));
			this.data.add(new BasicNameValuePair("Publisher", TouchHelper
					.getUser(context)));

			this.httpRegister = new HttpPostRegister(POST_TOUCH_CONNECTION,
					this.data);
			httpRegister.execute();
		}

	}

	private class HttpPostRegister extends AsyncTask<Void, Void, String> {

		private List<NameValuePair> mData;
		private String connection;

		public HttpPostRegister(String connection, ArrayList<NameValuePair> data) {
			this.connection = connection;
			this.mData = data;
		}

		@Override
		protected String doInBackground(Void... params) {
			if (TouchHelper.isOnline(context)) {
				if (!httpRegister.isCancelled()) {

					HttpClient client = new DefaultHttpClient();
					HttpPost post = new HttpPost(this.connection);

					String bearer = "Bearer " + TouchHelper.getToken(context);
					post.addHeader("Accept", "aplication/json");
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
				mLoading.setVisibility(View.INVISIBLE);
				mBtn_MakePost.setEnabled(true);

				Toast.makeText(context, "You've maked a Touch!",
						Toast.LENGTH_LONG).show();

				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			} else {
				Toast.makeText(context, result,
						Toast.LENGTH_LONG).show();
			}
			Intent intent = new Intent(context, ActivityMainScreen.class);
			startActivity(intent);
		}

		@Override
		protected void onPreExecute() {
			super.onPreExecute();
			mBtn_MakePost.setEnabled(false);
			mLoading.setVisibility(View.VISIBLE);
		}
	}
}