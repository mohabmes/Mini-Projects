<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Enroll extends CI_Controller {
  public function __construct(){
    parent::__construct();
    $this->loginCheck();
  }

  public function add(){
    echo $this->input->post('phone');
    $this->load->model('enroll_model');
    $this->load->model('student_model');
    $this->load->model('course_model');



    if(!empty($this->input->post("Add"))){
      $id = $this->input->post("student_id");
        $data = array(
          'student_id' => intval($this->input->post("student_id")),
          'course_id' => $this->input->post("course_id"),
          'date' => date("Y-m-d"),
          'user_id' => $this->session->id
        );

        $ocuppied_seats = $this->enroll_model->ocuppied_seats($data['course_id']);
        $seats = $this->course_model->fetch($data['course_id'])->seats;

        if($seats - $ocuppied_seats >= 1){
          if($this->enroll_model->insert($data)){
            $_SESSION['msg'] = "Successfully Enrolled.";
            redirect(base_url());
          }
          else {
            $_SESSION['msg'] = "This Student is Already Enrolled. ";
            redirect(base_url()."students/view/{$id}");
          }
        }
        else {
          $_SESSION['msg'] = "No Available Seats for this course. ";
          redirect(base_url()."students/view/{$id}");
        }
    }
    else {
      $student_id = $this->uri->segment(3);

      $data['student_data'] = $this->student_model->fetch($student_id);
      $data['course_data'] = $this->course_model->get_recent();

      $this->load->view('enroll', $data);
    }
  }

  public function unenroll(){
    $this->load->model('enroll_model');
    $course_id = $this->uri->segment(3);
    echo "remove ", $course_id;
    if(!empty($this->input->post("Unenroll"))){
      $student_id = $this->input->post("student_id");

      $data = array(
        'student_id' => $student_id,
        'course_id' => $course_id
      );

      if($this->enroll_model->delete($data)){
        $_SESSION['msg'] = "Successfully Unenrolled.";
        redirect(base_url()."students/view/{$student_id}");
      }
      else {
        $_SESSION['msg'] = "Error Ocurried. Please Try Again ";
        redirect(base_url()."students/view/{$student_id}");
      }
    }
  }

  public function loginCheck(){
    if(!isset($this->session->username)){
      redirect(base_url());
    }
  }
}
