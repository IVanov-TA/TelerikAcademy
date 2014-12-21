package com.example.friendstouch.util;

import java.io.ByteArrayOutputStream;
import java.util.regex.Pattern;

import android.content.Context;
import android.content.SharedPreferences;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.util.Base64;
import android.util.Patterns;

public class TouchHelper {

	private static final String KEY = "token";
	private static final String U_KEY = "user";

	public static Boolean checkMail(String email) {
		Pattern patern = Patterns.EMAIL_ADDRESS;
		if (!patern.matcher(email).matches()) {
			return false;
		}

		return true;
	}

	public static void storeToken(Context context, String token) {
		SharedPreferences preference = context.getSharedPreferences("Token", 0);
		SharedPreferences.Editor editor = preference.edit();
		editor.putString(KEY, token);
		editor.commit();
	}

	public static String getToken(Context context) {
		SharedPreferences preference = context.getSharedPreferences("Token", 0);
		return preference.getString(KEY, null) == null ? null : preference
				.getString(KEY, null);
	}

	public static void storeUser(Context context, String token) {
		SharedPreferences preference = context.getSharedPreferences("Token", 0);
		SharedPreferences.Editor editor = preference.edit();
		editor.putString(U_KEY, token);
		editor.commit();
	}

	public static String getUser(Context context) {
		SharedPreferences preference = context.getSharedPreferences("Token", 0);
		return preference.getString(U_KEY, null) == null ? null : preference
				.getString(U_KEY, null);
	}

	public static String BitMapToString(Bitmap bitmap) {
		ByteArrayOutputStream ByteStream = new ByteArrayOutputStream();
		bitmap.compress(Bitmap.CompressFormat.JPEG, 100, ByteStream);
		byte[] b = ByteStream.toByteArray();
		String temp = Base64.encodeToString(b, Base64.DEFAULT);
		return temp;
	}

	public static Bitmap StringToBitMap(String encodedString) {
		try {
			byte[] encodeByte = Base64.decode(encodedString, Base64.DEFAULT);
			Bitmap bitmap = BitmapFactory.decodeByteArray(encodeByte, 0,
					encodeByte.length);
			return bitmap;
		} catch (Exception e) {
			e.getMessage();
			return null;
		}
	}

	public static void clearPref(Context context) {
		SharedPreferences pf = context.getSharedPreferences("Token", 0);
		pf.edit().remove(KEY).clear().commit();
		pf.edit().remove(U_KEY).clear().commit();

	}

	public static boolean isOnline(Context context) {
		ConnectivityManager cm = (ConnectivityManager) context
				.getSystemService(Context.CONNECTIVITY_SERVICE);
		NetworkInfo netInfo = cm.getActiveNetworkInfo();
		if (netInfo != null && netInfo.isConnectedOrConnecting()) {
			return true;
		}
		return false;
	}
}
