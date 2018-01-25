<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Students extends CI_Controller {
	public function __construct(){
		parent::__construct();
		$this->loginCheck();
	}

	public function index(){
		$this->load->model("student_model");
		$data['student'] = $this->student_model->fetch_all();

		$this->load->view("student", $data);

	}


	public function add(){
		if($this->input->post("Add")){

			$this->load->library('form_validation');
			$this->load->model('student_model');

			$this->form_validation->set_rules('fname', 'Firstname', 'required');
			$this->form_validation->set_rules('lname', 'Lastname', 'required');
			// $this->form_validation->set_rules('email', 'email', 'required');
			$this->form_validation->set_rules('phone', 'Phone', 'required');
			// $this->form_validation->set_rules('address', 'Address', 'required');

			$now = date("Y-m-d");

			$data = array(
				'fname' => trim($this->input->post("fname")),
				'lname' => $this->input->post("lname"),
				'email' => $this->input->post("email"),
				'phone' => $this->input->post("phone"),
				'address' => $this->input->post("address"),
				'added' => $now
			);

			if($this->form_validation->run()){
				try{
					$ins = $this->student_model->insert($data);
				} catch(Exception $e)	{
					$_SESSION['msg'] = "This User is already exists." . $this->db->error();

				} finally {
					if($ins)
							$_SESSION['msg'] = "Successfully Added.";
					else
							$_SESSION['msg'] = "Something went wrong. (ex. Phone is Duplicated.)";
					redirect(base_url()."students/");
				}

			} else {
				$_SESSION['msg'] =  form_error("fname")." ".
								form_error("lname")." ".
								form_error("email")." ".
								form_error("phone")." ".
								form_error("note")." ".
								form_error("address");
				redirect(base_url() . "students/add");
			}

		} else {
			$this->load->view("add_student");
		}
	}

	public function search(){
		$this->load->model('student_model');
		$key = $this->input->get("s");

		if(isset($key)){
			$data['student_data'] = $this->student_model->search($key);
		}
		$data['op'] = "students";
		$data['key'] = $key;
		$this->load->view("search", $data);
	}


	public function view(){
		$this->load->model('student_model');
		$this->load->model('pay_model');

		$c_id = $this->uri->segment(3);

		$data['payment_data'] = $this->pay_model->fetch_payment($c_id);
		$data['paid_data'] = $this->calc_payment($data['payment_data']);
		$data['course_data'] = $this->student_model->course_data($c_id);
		$data['student_data'] = $this->student_model->fetch($c_id);

		$this->load->view('view_student', $data);
	}

	private function calc_payment($data =array()){

		$acc = array();
		// $all_data = array();
		foreach($data as $sp){
			if(isset($acc[$sp->title]))
				$acc[$sp->title] += $sp->fees;
			else
				$acc[$sp->title] = $sp->fees;
		}
		return $acc;
	}

	public function edit(){
		$this->load->library('form_validation');
		$this->load->model('student_model');

		if(!empty($this->input->post("Update"))){


			$this->form_validation->set_rules('fname', 'Firstname', 'required');
			$this->form_validation->set_rules('lname', 'Lastname', 'required');
			// $this->form_validation->set_rules('email', 'email', 'required');
			$this->form_validation->set_rules('phone', 'Phone', 'required');
			$this->form_validation->set_rules('address', 'Address', 'required');

			$data = array(
				'fname' => trim($this->input->post("fname")),
				'lname' => $this->input->post("lname"),
				'email' => $this->input->post("email"),
				'phone' => $this->input->post("phone"),
				'address' => $this->input->post("address")
			);

			if($this->form_validation->run()){

				if($this->student_model->update($data, $this->input->post("id"))){

						$_SESSION['msg'] = "Successfully updated.";
						redirect(base_url()."students/view/".$this->input->post("id"));
					}  else {
						$_SESSION['msg'] = "Something went wrong, Please try again.";
					}
			} else {
				$_SESSION['msg'] =  form_error("title")." ".
								form_error("instructor")." ".
								form_error("start_date")." ".
								form_error("end_date")." ".
								form_error("note")." ".
								form_error("tag");
				redirect(base_url()."students/view/".$this->input->post("id"));
			}
		}

		else {
			$c_id = $this->uri->segment(3);

			$data['student_data'] = $this->student_model->fetch($c_id);
			$data['op_type'] = 'update_student_info';
			$this->load->view('add_student', $data);
		}
	}


	public function loginCheck(){
		if(!isset($this->session->username)){
			redirect(base_url());
		}
	}
}
