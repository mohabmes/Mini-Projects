package com.example.mmes.DailyDiary;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class EditActivity extends AppCompatActivity {

    TextView date;
    EditText title;
    EditText txt;
    Button save;
    DBHandler db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit);

        db = new DBHandler(this, null, null, 1);
        date = (TextView) findViewById(R.id.date);
        title = (EditText) findViewById(R.id.title);
        txt = (EditText) findViewById(R.id.txt);
        save = (Button) findViewById(R.id.save);

        Bundle Diary_data = getIntent().getExtras();

        final String Diary_title, Diary_txt, Diary_date, Diary_id;

        Diary_id = Diary_data.getString("id");
        Diary_title = Diary_data.getString("title");
        Diary_txt = Diary_data.getString("txt");
        Diary_date = Diary_data.getString("date");

        date.setText(Diary_date);
        title.setText(Diary_title);
        txt.setText(Diary_txt);

        save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String Edited_title, Edited_txt;

                Edited_title = title.getText().toString();
                Edited_txt = txt.getText().toString();

                if(Edited_title.isEmpty()){Toast.makeText(getApplicationContext(), "Error : Title is Empty", Toast.LENGTH_LONG).show();}
                else if(Edited_title.length()<5){Toast.makeText(getApplicationContext(), "Error : Title is too short", Toast.LENGTH_LONG).show();}
                else if(Edited_title.length()>50){Toast.makeText(getApplicationContext(), "Error : Title is too long", Toast.LENGTH_LONG).show();}
                else if(Edited_txt.isEmpty()){Toast.makeText(getApplicationContext(), "Error : Diary text is Empty", Toast.LENGTH_LONG).show();}
                else{
                    db.updateDiary(Diary_id, Edited_title, Edited_txt, Diary_date);

                    Toast.makeText(getApplicationContext(), "Updated Successfully !", Toast.LENGTH_LONG).show();

                    Intent i = new Intent(getApplicationContext(), MainActivity.class);
                    startActivity(i);
                }
            }
        });

    }
}
