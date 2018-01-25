<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Auth extends CI_Controller {

	public function _construct(){
		parent::_construct();
		// if(!isset($this->session->username)){
		// 	$this->load->view('login');
		// 	redirect(base_url()."auth/login");
		// }
	}

	public function index()
	{
		if(!isset($this->session->username)){
					$this->load->view('login');
		}
		else {
			redirect(base_url() . "main/");
		}
	}

	public function login(){
		$this->load->view('login');

		$this->load->library('form_validation');
		$this->load->model('auth_model');


		if($this->input->post("login")){
			$this->form_validation->set_rules('username', 'username', 'required|alpha_numeric');
			$this->form_validation->set_rules('password', 'password', 'required|regex_match[/[a-zA-Z0-9_\-]+/]');

			$data = array(
				'username' => $this->input->post("username"),
				'password' => md5($this->input->post("password")),
				'created' => date('Y:m:d')
			);

			if($this->form_validation->run()){
				$user_data = $this->auth_model->fetch_user($data);

				if(isset($user_data)){

					$_SESSION['id'] = $user_data->id;
					$_SESSION['username'] = $user_data->username;
					$_SESSION['type'] = $user_data->type;
					redirect(base_url()."main");

				} else {
					$_SESSION['msg'] = "Username/Password incorrect";
					redirect(base_url());
				}
			} else {
				$_SESSION['msg'] = "All fields are required (username, password) ";
				redirect(base_url());
			}
		}
	}

	public function logout(){
		unset($_SESSION['id']);
		unset($_SESSION['username']);
		unset($_SESSION['type']);
		redirect(base_url());
	}

	public function view(){
		$this->load->model('auth_model');
		$data['admin_data'] = $this->auth_model->fetch_All();
		$this->load->view('users', $data);
	}

	public function register(){
		if($this->session->type != 0){
			redirect(base_url(). "main");
		}
		$this->load->view("register");

		if(!empty($this->input->post("Register"))){
			$this->load->library('form_validation');
			$this->load->model('auth_model');

			$this->form_validation->set_rules('username', 'username', 'required');
			$this->form_validation->set_rules('password', 'password', 'required');
			$this->form_validation->set_rules('type', 'password', 'required');

			if($this->form_validation->run()){
				$data = array(
					'username' => $this->input->post("username"),
					'password' => md5($this->input->post("password")),
					'type' => $this->input->post("type")
				);

				if($this->auth_model->insert_user($data)){
					$_SESSION['msg'] = "New User is added Successfully.";
					redirect(base_url()."main");
				}
				else{
					$_SESSION['msg'] = "Error Occurred. Please Try again (username must be unique)";
					redirect(base_url()."auth/register");
				}
			}
			else{
				$_SESSION['msg'] = "All fields are required (username, password) ";
				redirect(base_url()."auth/register");
			}
		}
	}

	public function rm(){
		$this->load->model('auth_model');
		$id = $this->uri->segment(3);
		$this->auth_model->rm($id);
		redirect(base_url() . "auth/view");
	}

}
