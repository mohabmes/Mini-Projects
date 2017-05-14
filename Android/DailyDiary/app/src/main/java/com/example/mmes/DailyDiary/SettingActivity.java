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

public class SettingActivity extends AppCompatActivity {

    EditText pass;
    Button save;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_setting);

        pass = (EditText) findViewById(R.id.getpass);
        save = (Button) findViewById(R.id.savepass);

        save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SharedPreferences sp = getSharedPreferences("userInfo", Context.MODE_PRIVATE);
                String txt = pass.getText().toString();
                SharedPreferences.Editor ed= sp.edit();

                ed.putString("pass", txt );
                ed.apply();

                // Test
                final SharedPreferences sp1 = getSharedPreferences("userInfo", Context.MODE_PRIVATE);
                final String p = sp1.getString("pass", null);
                Toast.makeText(getApplicationContext(), p, Toast.LENGTH_LONG).show();
                // Test


                Toast.makeText(getApplicationContext(), "Saved", Toast.LENGTH_LONG).show();
                Intent i = new Intent(getApplicationContext(), LoginActivity.class);
                startActivity(i);
            }
        });
    }
}
