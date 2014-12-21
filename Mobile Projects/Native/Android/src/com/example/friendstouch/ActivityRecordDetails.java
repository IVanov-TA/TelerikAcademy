package com.example.friendstouch;
import java.util.List;

import android.R.string;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import com.example.friendstouch.util.TouchHelper;

public class ActivityRecordDetails extends Activity implements OnClickListener{
    /** Called when the activity is first created. */
	
	public Button btn_NewComment;
	public Button btn_Location;
	
	private Record data;
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
    	super.onCreate(savedInstanceState);
		setContentView(R.layout.record_activity_screen);
		
		btn_NewComment = (Button)findViewById(R.id.btn_newComment);
		btn_Location = (Button)findViewById(R.id.btn_location);
		btn_NewComment.setOnClickListener(this);	
		btn_Location.setOnClickListener(this);
		
		ListView list = (ListView) findViewById(R.id.listViewComments);
		
		Intent i = getIntent();
		data = (Record)i.getSerializableExtra("data");
		List<Comment> comments = data.getComments();
		
		CommentAdapter adapter = new CommentAdapter(this,R.layout.comments_list_view, comments);
		list.setAdapter(adapter);	
		
		ImageView pic = (ImageView)findViewById(R.id.pic_comments);		
		pic.setImageBitmap(TouchHelper.StringToBitMap(data.getImage()));
		
		TextView author = (TextView)findViewById(R.id.txt_CommentAuthor);
		author.setText(data.getOwner());
		
		TextView message = (TextView)findViewById(R.id.txt_CommentMessage);
		message.setText(data.getPictureComment());
		
		TextView date = (TextView)findViewById(R.id.txt_CommentDate);
		date.setText(data.getDate().substring(0, 10));
	}
	
	@Override
	public void onClick(View v) {
		if (v == (Button) findViewById(R.id.btn_newComment)) {
		Intent myIntentComment = new Intent(v.getContext(), MakeNewComment.class);
		myIntentComment.putExtra("PostId", String.valueOf(data.getId()));
		startActivityForResult(myIntentComment, 0);
		} else {
			Intent intent = new Intent(v.getContext(), ActivityMap.class);
			String lt =  data.getLongitude();
			String lat = data.getLatitude();
			intent.putExtra("longitude", lt);
			intent.putExtra("latitude", lat);
			startActivityForResult(intent, 0);
		}
	}
}