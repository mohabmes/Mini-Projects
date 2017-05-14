package com.example.mmes.DailyDiary;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.content.Intent;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class ViewActivity extends AppCompatActivity {

    TextView date;
    TextView title;
    TextView txt;
    Button edit;
    Button delete;
    DBHandler db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view);

        db = new DBHandler(this, null, null, 1);
        date = (TextView) findViewById(R.id.date);
        title = (TextView) findViewById(R.id.title);
        txt = (TextView) findViewById(R.id.txt);
        edit = (Button) findViewById(R.id.edit);
        delete = (Button) findViewById(R.id.delete);

        Bundle Diary_data = getIntent().getExtras();

        final String Diary_title, Diary_txt, Diary_date, Diary_id;

        Diary_id = Diary_data.getString("id");
        Diary_title = Diary_data.getString("title");
        Diary_txt = Diary_data.getString("txt");
        Diary_date = Diary_data.getString("date");

        date.setText(Diary_date);
        title.setText(Diary_title);
        txt.setText(Diary_txt);

        delete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Delete Diary By ID
                db.deleteDiary(Diary_id);
                Toast.makeText(getApplicationContext(), "Deleted", Toast.LENGTH_LONG).show();
                Intent i = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(i);
            }
        });
        edit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(getApplicationContext(), EditActivity.class);

                i.putExtra("id", Diary_id);
                i.putExtra("title", Diary_title);
                i.putExtra("txt", Diary_txt);
                i.putExtra("date", Diary_date);

                startActivity(i);
            }
        });
    }
}
