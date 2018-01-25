<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Courses extends CI_Controller {

	public function __construct(){
		parent::__construct();
		$this->loginCheck();
	}


	public function index(){
		$this->load->model("course_model");
		$data['course'] = $this->course_model->fetch_all();

		$this->load->view("course", $data);

	}


	public function add(){
		if($this->input->post("Add")){

			$this->load->library('form_validation');
			$this->load->model('course_model');

			$this->form_validation->set_rules('title', 'title', 'required');
			$this->form_validation->set_rules('instructor', 'instructor', 'required');
			$this->form_validation->set_rules('start_date', 'starting date', 'required');
			$this->form_validation->set_rules('end_date', 'End date', 'required');
			// $this->form_validation->set_rules('note', 'note', 'required');
			$this->form_validation->set_rules('tag', 'tag', 'required');

			$data = array(
				'title' => trim($this->input->post("title")),
				'instructor' => $this->input->post("instructor"),
				'start_date' => $this->input->post("start_date"),
				'end_date' => $this->input->post("end_date"),
				'note' => $this->input->post("note"),
				'tag' => $this->input->post("tag")
			);

			if($this->form_validation->run()){
				if($this->course_model->insert($data)){
						$_SESSION['msg'] = "Successfully Added.";
						redirect(base_url()."courses/");
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
				redirect(base_url() . "courses/add");
			}

		} else {
			$this->load->view("add_course");
		}
	}

	public function search(){
		$this->load->model('course_model');
		$key = $this->input->get("s");

		if(isset($key)){
			$data['course_data'] = $this->course_model->search($key);
		}
		$data['op'] = "courses";
		$data['key'] = $key;
		$this->load->view("search", $data);
	}


	public function view(){
		$this->load->model('course_model');
		$c_id = $this->uri->segment(3);

		$data['course_data'] = $this->course_model->fetch($c_id);
		$data['student_data'] = $this->course_model->student_data($c_id);
		$this->load->view('view_course', $data);
	}


	public function edit(){
		$this->load->library('form_validation');
		$this->load->model('course_model');

		if(!empty($this->input->post("Update"))){
			$this->form_validation->set_rules('title', 'title', 'required');
			$this->form_validation->set_rules('instructor', 'instructor', 'required');
			$this->form_validation->set_rules('start_date', 'starting date', 'required');
			$this->form_validation->set_rules('end_date', 'End date', 'required');
			// $this->form_validation->set_rules('note', 'note', 'required');
			$this->form_validation->set_rules('tag', 'tag', 'required');

			$data = array(
				'title' => trim($this->input->post("title")),
				'instructor' => $this->input->post("instructor"),
				'start_date' => $this->input->post("start_date"),
				'end_date' => $this->input->post("end_date"),
				'note' => $this->input->post("note"),
				'tag' => $this->input->post("tag")
			);

			if($this->form_validation->run()){

				if($this->course_model->update($data, $this->input->post("id"))){

						$_SESSION['msg'] = "Successfully updated.";
						redirect(base_url()."courses/view/".$this->input->post("id"));
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
				redirect(base_url()."courses/view/".$this->input->post("id"));
			}
		}

		else {
			$c_id = $this->uri->segment(3);

			$data['course_data'] = $this->course_model->fetch($c_id);
			$data['op_type'] = 'update_course_info';
			$this->load->view('add_course', $data);
		}

	}
	
	public function loginCheck(){
		if(!isset($this->session->username)){
			redirect(base_url());
		}
	}


}
