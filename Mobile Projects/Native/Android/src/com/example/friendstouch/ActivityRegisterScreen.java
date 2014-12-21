package com.example.friendstouch;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.List;
import java.util.regex.Pattern;

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
import android.util.Log;
import android.util.Patterns;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

public class ActivityRegisterScreen extends Activity {

	private final String REGISTER_CONNECTION = "http://friendtouch.apphb.com/api/account/register";

	private HttpPostRegister httpRegister;
	private ArrayList<NameValuePair> data;

	private Button mRegister;
	private ProgressBar mLoading;
	private EditText mEmail;
	private EditText mPassword;
	private EditText mConfirmPassword;

	private TextView mRegisterLbl;
	private TextView mEmailLbl;
	private TextView mPasswordLbl;
	private TextView mConfPasseordLbl;

	Context context = this;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.register_screen);

		this.mRegisterLbl = (TextView) findViewById(R.id.txtRegistering);
		this.mEmailLbl = (TextView) findViewById(R.id.textView1);
		this.mPasswordLbl = (TextView) findViewById(R.id.textView2);
		this.mConfPasseordLbl = (TextView) findViewById(R.id.textView3);
		this.mLoading = (ProgressBar) findViewById(R.id.pb_Loading);
		this.mRegisterLbl.setVisibility(View.INVISIBLE);
		this.mLoading.setVisibility(View.INVISIBLE);

		this.mEmail = (EditText) findViewById(R.id.txtEmail);
		this.mPassword = (EditText) findViewById(R.id.txtPassword);
		this.mConfirmPassword = (EditText) findViewById(R.id.txtConfirmPassword);

		this.data = new ArrayList<NameValuePair>();

		mRegister = (Button) findViewById(R.id.btn_Register);

		mRegister.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				// Log.d("AsyncStatus",
				// String.valueOf(httpRegister.isCancelled()));
				String email = mEmail.getText().toString();
				String password = mPassword.getText().toString();
				String confirmPassword = mConfirmPassword.getEditableText()
						.toString();

				if (inputValidation(email, password, confirmPassword)) {
					data.add(new BasicNameValuePair("Email", email));
					data.add(new BasicNameValuePair("Password", password));
					data.add(new BasicNameValuePair("ConfirmPassword",
							confirmPassword));

					httpRegister = new HttpPostRegister(REGISTER_CONNECTION,
							data);
					httpRegister.execute();
				}
			}
		});
	}

	@Override
	protected void onStop() {
		super.onStop();
		if (httpRegister != null) {
			httpRegister.cancel(true);
		}
	}

	private Boolean inputValidation(String email, String password,
			String confirmPassword) {
		if (email.matches("")) {
			Toast.makeText(context, "Email field is empty", Toast.LENGTH_LONG)
					.show();
			return false;
		} else if (!TouchHelper.checkMail(email)) {
			Toast.makeText(context, "Invalid Email", Toast.LENGTH_LONG).show();
			return false;
		} else if (password.matches("")) {
			Toast.makeText(context, "Password field is empty",
					Toast.LENGTH_LONG).show();
			return false;
		} else if (confirmPassword.matches("")) {
			Toast.makeText(context, "Confirm Password field is empty",
					Toast.LENGTH_LONG).show();
			return false;
		} else if (password.length() < 6) {
			Toast.makeText(context, "Password must be atleast 6 symbls",
					Toast.LENGTH_LONG).show();
			return false;
		} else if (!password.equals(confirmPassword)) {
			Toast.makeText(context, "Passwords are not the same.",
					Toast.LENGTH_LONG).show();
			return false;
		} else {
			return true;
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
					// post.addHeader("Accept", "aplication/json");
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
				mLoading.setVisibility(View.INVISIBLE);
				mRegisterLbl.setVisibility(View.INVISIBLE);
				Toast.makeText(context, "You are registered", Toast.LENGTH_LONG)
						.show();
				try {
					Thread.sleep(2000);
				} catch (InterruptedException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				Intent intent = new Intent(context, MainActivity.class);
				startActivity(intent);
			}else {
				Toast.makeText(context, result, Toast.LENGTH_LONG).show();
			}
		}

		@Override
		protected void onPreExecute() {
			super.onPreExecute();
			mConfirmPassword.setVisibility(View.INVISIBLE);
			mEmail.setVisibility(View.INVISIBLE);
			mPassword.setVisibility(View.INVISIBLE);
			mRegister.setVisibility(View.INVISIBLE);
			mEmailLbl.setVisibility(View.INVISIBLE);
			mPasswordLbl.setVisibility(View.INVISIBLE);
			mConfPasseordLbl.setVisibility(View.INVISIBLE);
			mRegisterLbl.setVisibility(View.VISIBLE);
			mLoading.setVisibility(View.VISIBLE);
		}
	}
}