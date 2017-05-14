package com.example.mmes.DailyDiary;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.ArrayAdapter;
import android.widget.ListAdapter;

import java.util.ArrayList;


public class MainActivity extends AppCompatActivity {

    ListView dairyList;
    Button add;
    Button setting;
    DBHandler db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        dairyList = (ListView) findViewById(R.id.dairyList);
        add = (Button) findViewById(R.id.add);
        setting = (Button) findViewById(R.id.setting);
        db = new DBHandler(this, null, null, 1);

        final ArrayList<Diary> DiaryList = db.GetAllDiaryObj();
        String [] list_src = new String[DiaryList.size()];

        for(int i=0; i<DiaryList.size(); i++){
            list_src[i] = DiaryList.get(i).Get_date().toString().toUpperCase() + " |   " + DiaryList.get(i).Get_title();
        }


        //String [] list_src = {"Adam", "Mohab", "Desmond", "Cornelia", "Loaa"};
        ListAdapter adp = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, list_src);
        dairyList.setAdapter(adp);

        add.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(getApplicationContext(), AddActivity.class);
                startActivity(i);
            }
        });

        setting.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(getApplicationContext(), SettingActivity.class);
                startActivity(i);
            }
        });

        dairyList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Diary current = DiaryList.get(position);
                //Toast.makeText(getApplicationContext(), current.Get_title(), Toast.LENGTH_LONG).show();

                Intent i = new Intent(getApplicationContext(), ViewActivity.class);

                String Diary_title, Diary_txt, Diary_date,Diary_id;

                Diary_id = current.Get_id().toString();
                Diary_title = current.Get_title().toString();
                Diary_txt = current.Get_txt().toString();
                Diary_date = current.Get_date().toString().toUpperCase();

                i.putExtra("id", Diary_id);
                i.putExtra("title", Diary_title);
                i.putExtra("txt", Diary_txt);
                i.putExtra("date", Diary_date);

                startActivity(i);
            }
        });
    }
}
