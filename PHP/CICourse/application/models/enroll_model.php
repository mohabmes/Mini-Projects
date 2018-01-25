<?php
class Enroll_model extends CI_Model{
  public function insert($data = array()){
    $check = $this->db->insert('enrollment', $data);
    if($check){
      return true;
    }
    return false;
  }

  public function delete($data = array()){
    $this->db->where('student_id', $data['student_id']);
    $this->db->where('course_id', $data['course_id']);
    $query = $this->db->delete('enrollment');
    return $query;
  }

  public function ocuppied_seats($id){
    $sql = "SELECT COUNT(*) from enrollment where course_id = $id";

    $query = $this->db->query($sql);
    return $query->result_array()[0]['COUNT(*)'];
  }

  public function fetch_latest(){
    $this->db->select('courses.id as courses_id, courses.title as title, enrollment.date as date, students.lname, students.fname');
    $this->db->from('enrollment');
    $this->db->join('courses', 'enrollment.course_id = courses.id', 'inner');
    $this->db->join('students', 'enrollment.student_id = students.id', 'inner');
    $this->db->limit(10);

    $query = $this->db->get();
    return $query->result_array();
  }

}
