package com.example.mmes.DailyDiary;

/**
 * Created by MMES on 4/21/2017.
 */

public class Diary {
    private String _id;
    private String _title;
    private String _txt;
    private String _date;

    public  Diary(){ }

    public  Diary(String title, String txt, String date){
        this._title = title;
        this._date = date;
        this._txt = txt;
    }
    public  Diary(String id, String title, String txt, String date){
        this._id = id;
        this._title = title;
        this._date = date;
        this._txt = txt;
    }

    public String Get_id(){
        return _id;
    }
    public String Get_title(){
        return _title;
    }
    public String Get_txt(){
        return _txt;
    }
    public String Get_date(){
        return _date;
    }
}
