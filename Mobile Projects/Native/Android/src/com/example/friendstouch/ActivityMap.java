package com.example.friendstouch;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;

import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;

public class ActivityMap extends FragmentActivity {
    private GoogleMap mMap;
    
    private String latitude;
    private String longitude;
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.basic_demo);
        
        Intent intent = getIntent();
        this.latitude = intent.getStringExtra("latitude");
        this.longitude = intent.getStringExtra("longitude");
        
        // if no values
        if (this.latitude.matches("none") || this.longitude.matches("none")) {
			this.latitude = "24.223";
			this.longitude = "42.364";
		}
        
        setUpMapIfNeeded();
    }

    @Override
    protected void onResume() {
        super.onResume();
        setUpMapIfNeeded();
    }

    private void setUpMapIfNeeded() {
        if (mMap == null) {
            mMap = ((SupportMapFragment) getSupportFragmentManager().findFragmentById(R.id.map))
                    .getMap();
            if (mMap != null) {
                setUpMap();
            }
        }
    }

     private void setUpMap() {
        mMap.animateCamera(CameraUpdateFactory.zoomTo( 3.0f ) );  
        mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(new LatLng(Double.parseDouble(this.latitude),
        																Double.parseDouble(this.longitude)), 
        																6.0f));
        mMap.addMarker(new MarkerOptions()
        .position(new LatLng(Double.parseDouble(this.latitude),
    						 Double.parseDouble(this.longitude))));
    }
}