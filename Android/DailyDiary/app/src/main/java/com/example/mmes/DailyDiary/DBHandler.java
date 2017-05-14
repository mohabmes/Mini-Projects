package com.example.mmes.DailyDiary;

/**
 * Created by MMES on 4/21/2017.
 */

import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.content.Context;
import android.content.ContentValues;
import android.database.Cursor;

import java.util.ArrayList;


public class DBHandler extends SQLiteOpenHelper {
    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NAME = "daily-diary.db";
    //daily-diary.db
    private static final String TABEL_DIARY = "diary";
    private static final String COLUMN_ID = "_id";
    private static final String COLUMN_title = "_title";
    private static final String COLUMN_txt = "_txt";
    private static final String COLUMN_date = "_date";

    public DBHandler(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
        super(context, DATABASE_NAME, factory, DATABASE_VERSION);
    }


    @Override
    public void onCreate(SQLiteDatabase db) {
        String query =
                "CREATE TABLE " +  TABEL_DIARY + " ( "
                        + COLUMN_ID + " TEXT PRIMARY KEY AUTOINCREMENT , "
                        + COLUMN_title + " TEXT , "
                        + COLUMN_date + " TEXT , "
                        + COLUMN_txt + " TEXT "
                        + " )";
        db.execSQL(query);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXIST " + TABEL_DIARY);
        onCreate(db);
    }


    //Add new row to database
    public void addDiary(Diary obj){
        SQLiteDatabase db = getWritableDatabase();

        ContentValues values = new ContentValues();
        values.put(COLUMN_title, obj.Get_title());
        values.put(COLUMN_txt, obj.Get_txt());
        values.put(COLUMN_date, obj.Get_date());

        db.insert(TABEL_DIARY, null, values);
        db.close();
    }

    //Update new row to database
    public void updateDiary(String Diary_id, String Edited_title, String Edited_txt, String Diary_date){
        SQLiteDatabase db = getWritableDatabase();

        ContentValues values = new ContentValues();
        values.put(COLUMN_title , Edited_title);
        values.put(COLUMN_txt, Edited_txt);
        values.put(COLUMN_date, Diary_date.toUpperCase());

        db.update(TABEL_DIARY, values, "_id = ?",  new String[]{Diary_id});
        db.close();
    }


    //Delete product from the database
    public void deleteDiary(String id){
        SQLiteDatabase db = getWritableDatabase();
        db.delete("diary", COLUMN_ID+"=?", new String[]{id});
        db.close();
    }

    //Print out the database as a string
    public ArrayList<Diary> GetAllDiaryObj(){
        SQLiteDatabase db =  getWritableDatabase();

        String dbString = "";
        ArrayList<Diary> Diarylist = new ArrayList<Diary>();

        String query = "SELECT * FROM " + TABEL_DIARY + " WHERE 1";
        //Cursor point to a location in your result
        Cursor c = db.rawQuery(query, null);
        //Move to first row in your result
        c.moveToLast();

        //Position after the last row means the end of the results
        while (!c.isBeforeFirst()) {
            if (c.getString(c.getColumnIndex(COLUMN_title)) != null) {

                String title, txt, date, id;

                id = c.getString(c.getColumnIndex(COLUMN_ID));
                title = c.getString(c.getColumnIndex(COLUMN_title));
                txt = c.getString(c.getColumnIndex(COLUMN_txt));
                date = c.getString(c.getColumnIndex(COLUMN_date));

                Diary tmp = new Diary(id, title, txt, date);

                Diarylist.add(tmp);

            }
            c.moveToPrevious();
        }
        db.close();
        return Diarylist;
    }
}
