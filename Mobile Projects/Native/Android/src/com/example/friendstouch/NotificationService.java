package com.example.friendstouch;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.entity.UrlEncodedFormEntity;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import com.example.friendstouch.util.TouchHelper;

import android.R.integer;
import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.app.Service;
import android.app.TaskStackBuilder;
import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;
import android.os.IBinder;
import android.util.Log;
import android.widget.Toast;

public class NotificationService extends Service {
	private MyThread mythread;
	public boolean isRunning = false;
	Context context = this;
	
	@Override
	public IBinder onBind(Intent arg0) {
		return null;
	}

	@Override
	public void onCreate() {
		super.onCreate();
		mythread = new MyThread();
		if (!isRunning) {
			mythread.start();
			isRunning = true;
		}
	}

	@Override
	public synchronized void onDestroy() {
		super.onDestroy();
		if (!isRunning) {
			mythread.interrupt();
			mythread.interrupt();
		}
	}

	public void getNewestPosts() {
		if (TouchHelper.isOnline(this)) {
			HttpClient client = new DefaultHttpClient();
			HttpGet get = new HttpGet("http://friendtouch.apphb.com/api/services/getnotifications");

			get.addHeader("Authorization", "Bearer " + TouchHelper.getToken(this));
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
					int count = new JSONArray(sb.toString()).length();
					if (count > 0) {
						createImportantNotification(count);
					}
				}

			} catch (Exception e) {
				e.printStackTrace();
			}
		}
	}
	
	public void updateReaded(){
		if (TouchHelper.isOnline(this)) {
			HttpClient client = new DefaultHttpClient();
			HttpGet get = new HttpGet("http://friendtouch.apphb.com/api/services/updatenotification");

			get.addHeader("Authorization", "Bearer " + TouchHelper.getToken(this));
			
			try {
				client.execute(get);
			} catch (Exception e) {
				e.printStackTrace();
			}
		}
			
	}
	
	public void createImportantNotification(int count) {
		String msg = "You have " + count + " new "
				+ (count > 1 ? "touches" : "touche");
		Notification.Builder builder = new Notification.Builder(context)
				.setSmallIcon(R.drawable.ic_launcher).setContentText(msg);

		Intent resultIntent = new Intent(context, ActivityMainScreen.class);

		TaskStackBuilder stackBuilder = TaskStackBuilder.create(context);

		stackBuilder.addParentStack(ActivityMainScreen.class);

		stackBuilder.addNextIntent(resultIntent);
		PendingIntent resultPendingIntent = stackBuilder.getPendingIntent(
				0, PendingIntent.FLAG_UPDATE_CURRENT);

		builder.setContentIntent(resultPendingIntent);
		NotificationManager notificationManager = (NotificationManager) getSystemService(Context.NOTIFICATION_SERVICE);

		Notification notification = builder.build();
		notification.flags = Notification.FLAG_AUTO_CANCEL
				| Notification.FLAG_NO_CLEAR | Notification.DEFAULT_SOUND
				| Notification.FLAG_SHOW_LIGHTS
				| Notification.PRIORITY_HIGH;

		notificationManager.notify(R.id.important_notification_id,
				notification);
		updateReaded();
	}

	class MyThread extends Thread {
		static final long DELAY = 20000;

		@Override
		public void run() {
			while (isRunning) {
				try {
					getNewestPosts();
					Thread.sleep(DELAY);
				} catch (InterruptedException e) {
					isRunning = false;
					e.printStackTrace();
				}
			}
		}

		
	}

}
