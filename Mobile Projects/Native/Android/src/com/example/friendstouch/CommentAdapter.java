package com.example.friendstouch;
import java.text.SimpleDateFormat;
import java.util.List;
import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;

import android.widget.TextView;

public class CommentAdapter extends ArrayAdapter<Comment> {
	private Context context;
	private int layoutId;
	private List<Comment> comments;
	public CommentAdapter(Context context, int resource, List<Comment> objects) {
		super(context, resource, objects);
		this.context = context;
		this.layoutId = resource;
		this.comments = objects;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		LayoutInflater inflator = ((Activity)context).getLayoutInflater();
		View row = inflator.inflate(layoutId, parent,false);

//		ImageView pic = (ImageView) row.findViewById(R.id.picture);		
//		pic.setBackgroundResource(dataRecords.get(position).getImage());
		
		TextView author = (TextView) row.findViewById(R.id.comment_author);
		TextView date = (TextView) row.findViewById(R.id.comment_data);
		TextView message = (TextView) row.findViewById(R.id.comment_message);
		
		// get author
		author.setText(comments.get(position).getOwner());
		
		// get Date comment is posted
		String timePosted = comments.get(position).getTime().length() > 10 ?
				comments.get(position).getTime().substring(0, 10) : 
					comments.get(position).getTime();
		date.setText(timePosted);
		
		// get comment body text
		message.setText(comments.get(position).getMessage());
		return row;	
	}
}