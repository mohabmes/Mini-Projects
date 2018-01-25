<?php
class Course_model extends CI_Model{

  # inserting user
  public function insert($data = array()){
    $check = $this->db->insert('courses', $data);
    if($check){
      return true;
    }
    return false;
  }

  public function fetch_all(){
    $sql = "SELECT * FROM `courses` ORDER by id DESC";
    // $this->db->order_by('id', 'DESC');
    $query = $this->db->query($sql);
    return $query->result_array();
  }

  public function fetch_latest(){
    $sql = "SELECT * FROM `courses` ORDER by id DESC LIMIT 0,10";
    // $this->db->order_by('id', 'DESC');
    $query = $this->db->query($sql);
    return $query->result_array();
  }

  public function update($data, $id){
    $this->db->where("id", $id);
    if($this->db->update("courses", $data)){
      return true;
    }
    else {
      return false;
    }
  }


  # fetch course data
  public function fetch($id){
    $this->db->where("id", $id);
    // $this->db->where("password", $data['password']);
    $query = $this->db->get("courses");
    return $query->first_row();
  }


  public function search($key){
    $sql = "SELECT * FROM `courses` WHERE `title` LIKE '%{$key}%'
            OR `instructor` LIKE '%{$key}%'
            OR `note` LIKE '%{$key}%'
            OR `tag` LIKE '%{$key}%' ";
    // $this->db->order_by('id', 'DESC');
    $query = $this->db->query($sql);
    return $query->result_array();
  }

  public function get_recent(){
    $now = date("Ymd");
    $sql = "SELECT * FROM `courses` WHERE `end_date` > {$now}";
    // $this->db->order_by('id', 'DESC');
    $query = $this->db->query($sql);
    return $query->result_array();
  }

  public function student_data($id){
    $sql = "SELECT enrollment.student_id as sid,
                    students.fname as fname, students.lname as lname,
                    enrollment.date as edate,  students.phone as phone
            FROM enrollment INNER JOIN students on enrollment.student_id = students.id
            WHERE enrollment.course_id = {$id}";
    $query = $this->db->query($sql);
    return $query->result_array();
  }
}
