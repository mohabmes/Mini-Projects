<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Main extends CI_Controller {

	public function __construct(){
		parent::__construct();
		$this->loginCheck();
	}

	public function loginCheck(){
		if(!isset($this->session->username)){
			redirect(base_url());
		}
	}

	public function index()
	{
		$this->load->model("student_model");
		$this->load->model("course_model");
		$this->load->model("pay_model");
		$this->load->model("enroll_model");
		$data['course_data'] = $this->enroll_model->fetch_latest();
		$data['payment_data'] = $this->pay_model->fetch_latest();
		$data['course'] = $this->course_model->fetch_latest();
		$data['student'] = $this->student_model->fetch_latest();

		$this->load->view("dashboard", $data);
	}


}
