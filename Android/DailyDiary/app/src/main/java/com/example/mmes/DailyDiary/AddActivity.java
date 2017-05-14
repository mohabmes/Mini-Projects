package com.example.mmes.DailyDiary;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import java.text.SimpleDateFormat;
import java.util.Date;


public class AddActivity extends AppCompatActivity {

    Button save;
    EditText title, txt;
    DBHandler db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add);

        save = (Button) findViewById(R.id.save);
        title = (EditText) findViewById(R.id.title);
        txt = (EditText) findViewById(R.id.txt);

        save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String stitle;
                String  stxt;
                stitle = title.getText().toString();
                stxt = txt.getText().toString();

                if(stitle.isEmpty()){Toast.makeText(getApplicationContext(), "Error : Title is Empty", Toast.LENGTH_LONG).show();}
                else if(stitle.length()<5){Toast.makeText(getApplicationContext(), "Error : Title is too short", Toast.LENGTH_LONG).show();}
                else if(stitle.length()>50){Toast.makeText(getApplicationContext(), "Error : Title is too long", Toast.LENGTH_LONG).show();}
                else if(stxt.isEmpty()){Toast.makeText(getApplicationContext(), "Error : Diary text is Empty", Toast.LENGTH_LONG).show();}
                else{

                    String date = new SimpleDateFormat("MMM dd").format(new Date());

                    db = new DBHandler(getApplicationContext(), null, null, 1);
                    db.addDiary(new Diary(stitle, stxt, date));

                    Toast.makeText(getApplicationContext(), date, Toast.LENGTH_LONG).show();
                    Toast.makeText(getApplicationContext(), "Done, Here We Go", Toast.LENGTH_LONG).show();
                    Intent i = new Intent(getApplicationContext(), MainActivity.class);
                    startActivity(i);
                }
            }
        });
    }
}
