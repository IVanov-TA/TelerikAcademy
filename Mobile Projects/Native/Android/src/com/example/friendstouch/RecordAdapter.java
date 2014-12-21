package com.example.friendstouch;
import java.util.List;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.friendstouch.util.TouchHelper;

public class RecordAdapter extends ArrayAdapter<Record> {
	private Context context;
	private int layoutId;
	private List<Record> dataRecords;
	
	public RecordAdapter(Context context, int resource, List<Record> objects) {
		super(context, resource, objects);
		this.context = context;
		this.layoutId = resource;
		this.dataRecords = objects;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		LayoutInflater inflator = ((Activity)context).getLayoutInflater();
		View row = inflator.inflate(layoutId, parent,false);

		ImageView pic = (ImageView) row.findViewById(R.id.picture);		
		pic.setImageBitmap(TouchHelper.StringToBitMap(dataRecords.get(position).getImage()));

		TextView author = (TextView) row.findViewById(R.id.author);
		TextView date = (TextView) row.findViewById(R.id.data);
		TextView message = (TextView) row.findViewById(R.id.message);
		author.setText(dataRecords.get(position).getOwner());
		
		// String dateStr = new SimpleDateFormat("yyyy-MM-dd HH:mm").format(dataRecords.get(position).getTime());
		date.setText(dataRecords.get(position).getDate().substring(0, 10));
		
		message.setText(dataRecords.get(position).getPictureComment());
		return row;	
	}
}
