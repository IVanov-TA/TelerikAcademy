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
import org.json.JSONException;
import org.json.JSONObject;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.Toast;

import com.example.friendstouch.util.TouchHelper;
import com.google.android.gms.common.api.GoogleApiClient;
import com.google.android.gms.drive.Drive;

public class MainActivity extends Activity implements OnClickListener {

	private final String GRANT_TYPE = "grant_type";
	private final String GRANT_TYPE_PASSWORD = "password";
	private final String USER_NAME = "username";
	private final String PASSWORD = "password";

	private final String ACCESS_TOKEN = "access_token";
	private final String USERNAME = "userName";

	private final String LOGGIN_CONNECTION = "http://friendtouch.apphb.com/token";

	private Button btn_Login;
	private Button btn_Register;

	private EditText it_Username;
	private EditText it_Password;

	private ProgressBar mLoading;

	private ArrayList<NameValuePair> mData;

	private CheckBox check_Box;

	private HttpPostLogin mHttpLogin;

	private Context context = this;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		
		// temporary use//
		TouchHelper.clearPref(context);
		// ///////////////

		this.mData = new ArrayList<NameValuePair>();

		btn_Login = (Button) findViewById(R.id.login);
		btn_Register = (Button) findViewById(R.id.not_registered);

		it_Username = (EditText) findViewById(R.id.username);
		it_Password = (EditText) findViewById(R.id.password);

		check_Box = (CheckBox) findViewById(R.id.logged);
		
		Intent serviceIntent = new Intent(this, NotificationService.class);
		startService(serviceIntent);
		
		this.mLoading = (ProgressBar) findViewById(R.id.pbLoginLoading);

		String tk = TouchHelper.getToken(context);
		if (tk != null) {
			Intent intent1 = new Intent(context, ActivityMainScreen.class);
			intent1.putExtra("token", tk);
			startActivity(intent1);
		} else {
			btn_Login.setOnClickListener(this);
			btn_Register.setOnClickListener(this);
		}

	}

	@Override
	protected void onStop() {
		super.onStop();
		if (this.mHttpLogin != null) {
			this.mHttpLogin.cancel(true);
		}
	}

	public void onClick(View v) {
		if (v == (Button) findViewById(R.id.login)) {
			if (this.mHttpLogin == null) {

				// TODO :Remove this autologin on stable app /just for easy
				// testing/
				String userName = this.it_Username.getText().toString();
				String password = this.it_Password.getText().toString();

				if (checkLogin(userName, password)) {
					this.mData.add(new BasicNameValuePair(GRANT_TYPE,
							GRANT_TYPE_PASSWORD));
					this.mData.add(new BasicNameValuePair(USER_NAME, userName));
					this.mData.add(new BasicNameValuePair(PASSWORD, password));

					
				Intent backServiceIntent = new Intent(context, NotificationService.class);
				startService(backServiceIntent);
					this.mHttpLogin = new HttpPostLogin(LOGGIN_CONNECTION,
							mData);
					this.mHttpLogin.execute(LOGGIN_CONNECTION);
					// Log.d("Async", "Started");
				}
			}
		} else if (v == (Button) findViewById(R.id.not_registered)) {
			Intent myIntent = new Intent(v.getContext(),
					ActivityRegisterScreen.class);
			startActivityForResult(myIntent, 0);
		}
	}

	private Boolean checkLogin(String userName, String password) {
		if (!TouchHelper.checkMail(userName)) {
			Toast.makeText(context, "Invalid Email", Toast.LENGTH_LONG).show();
			return false;
		} else if (password.matches("")) {
			Toast.makeText(context, "Password field is empty",
					Toast.LENGTH_LONG).show();
			return false;
		} else if (password.length() < 6) {
			Toast.makeText(context, "Password must be atleast 6 symbls",
					Toast.LENGTH_LONG).show();
			return false;
		} else {
			return true;
		}
	}

	@Override
	protected void onResume() {
		super.onResume();
		this.mLoading.setVisibility(View.INVISIBLE);
	}

	@Override
	protected void onDestroy() {
		super.onDestroy();
//		if (!this.check_Box.isChecked()) {
//			TouchHelper.clearPref(context);
//		}
	}
	
	private class HttpPostLogin extends AsyncTask<String, Void, String> {

		private List<NameValuePair> mData;

		public HttpPostLogin(String connection, ArrayList<NameValuePair> data) {
			// this.connection = connection;
			this.mData = data;
		}

		@Override
		protected String doInBackground(String... params) {
			if (TouchHelper.isOnline(context)) {

				if (!mHttpLogin.isCancelled()) {
					HttpClient client = new DefaultHttpClient();
					HttpPost post = new HttpPost(params[0]);
					// get.addHeader("Accept", "aplication/json");

					InputStream inputStream;
					;
					InputStreamReader inputReader = null;

					try {
						post.setEntity(new UrlEncodedFormEntity(mData));
						HttpResponse response = client.execute(post);
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
							client.getConnectionManager().shutdown();
							inputReader.close();
						}
						return sb.toString();
						// Log.d("D1", sb.toString());
					} catch (UnsupportedEncodingException e) {
						return e.getMessage().toString();
					} catch (ClientProtocolException e) {
						return e.getMessage().toString();
					} catch (IOException e) {
						return e.getMessage().toString();
					}

				}
				// finally {
				// client.getConnectionManager().shutdown();
				// try {
				// inputReader.close();
				// } catch (IOException e) {
				// e.printStackTrace();
				// }
				// }
			}

			return "No connection";
		}

		@Override
		protected void onPostExecute(String result) {
			super.onPostExecute(result);
			if (!result.matches("No connection")) {
				JSONObject recievedJson = null;
				try {
					recievedJson = new JSONObject(result);
					// String tString = recievedJson.getString(ACCESS_TOKEN);
					// Toast.makeText(context,
					// recievedJson.getString(ACCESS_TOKEN),
					// Toast.LENGTH_LONG).show();

					TouchHelper.storeToken(context,
							recievedJson.getString(ACCESS_TOKEN));
					TouchHelper.storeUser(context,
							recievedJson.getString(USERNAME));

					// Log.d("Token", recievedJson.getString(ACCESS_TOKEN));
				} catch (JSONException e1) {
					e1.printStackTrace();
				}

				Intent myIntent = new Intent(context, ActivityMainScreen.class);
				startActivityForResult(myIntent, 0);

				btn_Login.setVisibility(View.VISIBLE);
				mLoading.setVisibility(View.INVISIBLE);
			}else {
				Toast.makeText(context, result, Toast.LENGTH_LONG).show();
			}
		}

		@Override
		protected void onPreExecute() {
			super.onPreExecute();
			btn_Login.setVisibility(View.INVISIBLE);
			mLoading.setVisibility(View.VISIBLE);
		}
	}
}
