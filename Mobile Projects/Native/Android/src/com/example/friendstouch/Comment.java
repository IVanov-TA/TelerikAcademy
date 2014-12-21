package com.example.friendstouch;

import java.io.Serializable;

@SuppressWarnings("serial") 
public class Comment implements Serializable {
	private String owner;
	private String date;
	private String message;
	
	public Comment(String owner, String message, String date){
		this.owner = owner;
		this.date = date;
		this.message = message;
	}
	
	public String getOwner() {
		return owner;
	}
	public void setOwner(String owner) {
		this.owner = owner;
	}
	
	public String getTime() {
		return date;
	}
	public void setTime(String time) {
		this.date = time;
	}
	
	public String getMessage() {
		return message;
	}
	public void setMessage(String message) {
		this.message = message;
	}
}
