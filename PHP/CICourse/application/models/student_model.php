<?php
class Student_model extends CI_Model{

  # inserting user
  public function insert($data = array()){
    $check = $this->db->insert('students', $data);
    if($check){
      return true;
    }
    return false;
  }

  public function fetch_all(){
    $sql = "SELECT * FROM `students` ORDER by id DESC";
    $query = $this->db->query($sql);
    return $query->result_array();
  }

  public function fetch_latest(){
    $sql = "SELECT * FROM `students` ORDER by id DESC LIMIT 0,10";
    $query = $this->db->query($sql);
    return $query->result_array();
  }

  public function update($data, $id){

    $this->db->where("id", $id);
    if($this->db->update("students", $data)){
      return true;
    }
    else {
      return false;
    }
  }


  # fetch student data
  public function fetch($id){
    $this->db->where("id", $id);
    // $this->db->where("password", $data['password']);
    $query = $this->db->get("students");
    return $query->first_row();
  }


  public function search($key){
    $sql = "SELECT * FROM `students` WHERE `fname` LIKE '%{$key}%'
            OR `lname` LIKE '%{$key}%'
            OR `phone` LIKE '%{$key}%'";
    // $this->db->order_by('id', 'DESC');
    $query = $this->db->query($sql);
    return $query->result_array();
  }

  public function course_data($id){
    $sql = "SELECT enrollment.student_id as sid, courses.title as ctitle, courses.id as cid, enrollment.date as edate FROM enrollment
            INNER JOIN courses on enrollment.course_id = courses.id
            WHERE enrollment.student_id = {$id}";
    $query = $this->db->query($sql);
    return $query->result_array();
  }


}

//SELECT enrollment.student_id as sid, courses.title FROM enrollment INNER JOIN courses on enrollment.course_id = courses.id
