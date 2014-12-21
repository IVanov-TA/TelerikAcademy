package com.example.friendstouch;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

@SuppressWarnings("serial")
public class Record implements Serializable {
	private int id;
	private String latitude;
	private String longitude;
	private String owner;
	private String date;
	private String image;
	private String pictureComment;
	private ArrayList<Comment> comments;
	
	public Record(int id, String owner, String pictureComment, String image, String date, String latitude, String longitude){
		this.id = id;
		this.owner = owner;
		this.pictureComment = pictureComment;
		this.date = date;
		this.image = image;
		this.latitude = latitude;
		this.longitude = longitude;
		this.comments = new ArrayList<Comment>();
	}
	
	public String getOwner() {
		return owner;
	}
	public void setOwner(String owner) {
		this.owner = owner;
	}
	
	public String getDate() {
		return date;
	}
	public void setDate(String date) {
		this.date = date;
	}
	
	public String getImage() {
		return image;
	}
	public void setImage(String image) {
		this.image = image;
	}
	
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getLatitude() {
		return latitude;
	}

	public void setLatitude(String latitude) {
		this.latitude = latitude;
	}

	public String getLongitude() {
		return longitude;
	}

	public void setLongitude(String longitude) {
		this.longitude = longitude;
	}
	
	public String getPictureComment() {
		return pictureComment;
	}
	public void setPictureComment(String pictureComment) {
		this.pictureComment = pictureComment;
	}
	
	public List<Comment> getComments() {
		return comments;
	}
	public void setComments(Comment comment) {
		this.comments.add(comment);
	}
}
