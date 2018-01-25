<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Pay extends CI_Controller {
  public function __construct(){
    parent::__construct();
    $this->loginCheck();
  }


  public function loginCheck(){
    if(!isset($this->session->username)){
      redirect(base_url());
    }
  }


  public function add(){
    $id = $this->uri->segment(3);
    $this->load->model('pay_model');
    $this->load->model('student_model');

    if($this->input->post("Pay")){
      $this->load->library('form_validation');

			$this->form_validation->set_rules('course_id', 'course', 'required');
			$this->form_validation->set_rules('fees', 'fees', 'required');


			$data = array(
				'course_id' => trim($this->input->post("course_id")),
				'fees' => $this->input->post("fees"),
				'student_id' => $this->input->post("student_id"),
				'date' => date('Y-m-d'),
        'admin_id' => $_SESSION['id']
			);

      if($this->form_validation->run()){

        if($this->pay_model->valid($data)){

          if($this->pay_model->insert($data)){
            $_SESSION['msg'] = "Successfully Added.";
            redirect(base_url()."students/view/".$this->input->post("student_id"));
          }  else {
            $_SESSION['msg'] = "Something went wrong, Please try again.";
            redirect(base_url()."pay/add/".$this->input->post("student_id"));
          }

        } else {
          $_SESSION['msg'] =  "Invalid Payment Operation. (check Payment History first)";
          redirect(base_url()."pay/add/".$this->input->post("student_id"));
        }

      }else {
				$_SESSION['msg'] =  form_error("fees")." ".
								          form_error("course_id");
				redirect(base_url()."pay/add/".$this->input->post("student_id"));
			}

    }
    else {
      $data['enrollment'] = $this->pay_model->fetch_enrollment($id);
      $data['student'] = $this->student_model->fetch($id);
      $this->load->view('pay', $data);
    }


  }
}
