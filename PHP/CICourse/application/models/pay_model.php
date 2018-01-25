<?php
class Pay_model extends CI_Model{

  public function insert($data = array()){
    $check = $this->db->insert('payment', $data);
    if($check){
      return true;
    }
    return false;
  }

  public function delete($data = array()){
    $this->db->where('student_id', $data['student_id']);
    $this->db->where('course_id', $data['course_id']);
    $query = $this->db->delete('payment');
    return $query;
  }

  // public function fetch_enrollment($id){
  //   $this->db->select('student_id');
  //
  //   $query = $this->db->query($sql);
  //   return $query->result_array()[0]['COUNT(*)'];
  // }

  public function fetch_enrollment($id){
    $this->db->select('courses.id as courses_id, courses.title as title');
    $this->db->from('enrollment');
    $this->db->join('courses', 'enrollment.course_id = courses.id', 'inner');
    $this->db->where('enrollment.student_id', $id);

    $query = $this->db->get();
    $data = $query->result();
    return $data;
  }

  public function fetch_payment($id){
    $this->db->select('courses.id, courses.title, courses.price, payment.date, payment.fees, payment.admin_id, users.username');
    $this->db->from('payment');
    $this->db->join('courses', 'payment.course_id = courses.id', 'inner');
    $this->db->join('users', 'payment.admin_id = users.id', 'inner');
    $this->db->where('payment.student_id', $id);
    $this->db->order_by('date', 'ASC');

    $query = $this->db->get();
    $data = $query->result();
    return $data;
  }

  public function fetch_latest(){
    $this->db->select('courses.id, courses.title, courses.price, payment.date, payment.fees, payment.admin_id, users.username, students.fname, students.lname');
    $this->db->from('payment');
    $this->db->join('students', 'payment.student_id = students.id', 'inner');
    $this->db->join('courses', 'payment.course_id = courses.id', 'inner');
    $this->db->join('users', 'payment.admin_id = users.id', 'inner');
    $this->db->limit(10);

    $query = $this->db->get();
    $data = $query->result();
    return $data;
  }

  public function get_course_price($id){
    $this->db->select('price');
    $this->db->from('courses');
    $this->db->where('id ', $id);

    $query = $this->db->get();
    $price = $query->result()[0]->price;
    return $price;
  }

  public function valid($data = array()){
    $this->db->select('SUM(fees) as sum');
    $this->db->from('payment');
    $this->db->where('payment.course_id ', $data['course_id']);
    $this->db->where('payment.student_id', $data['student_id']);

    $query = $this->db->get();
    $sum = $query->result()[0]->sum;

    if((int)$sum + (int)$data['fees'] >= 0 &&
        (int)$sum + (int)$data['fees'] <= (int)$this->get_course_price($data['course_id']) ){
      return true;
    }

    return false;
  }
}
