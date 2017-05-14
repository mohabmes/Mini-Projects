package com.example.mmes.DailyDiary;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {

    Button login;
    EditText pass;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        login = (Button) findViewById(R.id.login);
        pass = (EditText) findViewById(R.id.pass);

        final SharedPreferences sp = getSharedPreferences("userInfo", Context.MODE_PRIVATE);
        final String p = sp.getString("pass", null);

        Toast.makeText(getApplicationContext(), "Password = "+ p, Toast.LENGTH_LONG).show();

        login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if( p.equalsIgnoreCase( pass.getText().toString() ) ){
                    Toast.makeText(getApplicationContext(), "Welcome", Toast.LENGTH_LONG).show();
                    Intent i = new Intent(getApplicationContext(), MainActivity.class);
                    startActivity(i);
                }
                else{
                    Toast.makeText(getApplicationContext(), "Please, Try again", Toast.LENGTH_LONG).show();
                }
            }
        });
    }
}
