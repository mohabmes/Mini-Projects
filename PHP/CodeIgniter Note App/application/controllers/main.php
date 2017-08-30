<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Main extends CI_Controller {

	public function index()
	{
		if(!isset($this->session->username)){
			redirect(base_url() . "main/login");
		}
		else {

			$this->load->model("note_op");
			$data['user_notes'] = $this->note_op->fetch_user_notes($_SESSION['id']);

			$this->load->view('index', $data);

		}
	}

	public function register(){
		if(isset($this->session->username)){
			redirect(base_url());
		}
		$this->load->view('register');
	}

	# form_validation is used to validate Login & register Form
	public function form_validation(){
		#load built-in form_validation library
		$this->load->library('form_validation');
		#load athuntication system model
		$this->load->model('athun_system');
		$this->load->model('note_op');

		# requset is sent from login form
		if($this->input->post("login")){
			$this->form_validation->set_rules('username', 'username', 'required|alpha_numeric');
			$this->form_validation->set_rules('password', 'password', 'required|regex_match[/[a-zA-Z0-9_\-]+/]');

			$data = array(
				'username' => $this->input->post("username"),
				'password' => $this->input->post("password"),
			);

			if($this->form_validation->run()){
				# fetch user data
				$user_data = $this->athun_system->fetch_user($data);

				# check if user exist in db
				if(isset($user_data)){

					$_SESSION['id'] = $user_data->id;
					$_SESSION['username'] = $user_data->username;
					$_SESSION['fullname'] = $user_data->fullname;
					redirect(base_url());

				} else {
					$_SESSION['msg'] = "Username/Password incorrect";
					redirect(base_url() . "main/login");
				}

			} else {
				$_SESSION['msg'] = form_error("username")." ".form_error("password");
				redirect(base_url() . "main/login");
			}
		}
		# End of Login Proc

		# requset is sent from registeration form
		if($this->input->post("register")){
				$this->form_validation->set_rules('fullname', 'fullname', 'required|alpha_numeric_spaces');
				$this->form_validation->set_rules('username', 'username', 'required|alpha_numeric');
				$this->form_validation->set_rules('password', 'password', 'required|regex_match[/[a-zA-Z0-9_\-]+/]');
				$this->form_validation->set_rules('password_again', 'password_again', 'matches[password]');

				$data = array(
					'fullname' => trim($this->input->post("fullname")),
					'username' => $this->input->post("username"),
					'password' => $this->input->post("password"),
				);

				if($this->form_validation->run()){

					if($this->athun_system->insert_user($data)){
						$_SESSION['msg'] = "Successfully Registered, Please Login.";
						redirect(base_url()."main/login");
					}
				} else {
					$_SESSION['msg'] = form_error("fullname")." ".
									form_error("username")." ".
									form_error("password")." ".
									form_error("password_again");
					redirect(base_url() . "main/register");
				}
		}
		# End of registeration Proc

		# requset is sent from Add-note form
		if($this->input->post("add")){
			$this->form_validation->set_rules('title', 'title', 'required');
			$this->form_validation->set_rules('body', 'body', 'required');

			$data = array(
				'title' => $this->input->post("title"),
				'body' => $this->input->post("body"),
				'date' => date("M d, Y"),
				'id_user' => $_SESSION['id']
			);
			if($this->form_validation->run()){
				$this->note_op->insert_note($data);
				$_SESSION['msg'] = "Added Successfully";
				redirect(base_url());
			} else {
				$_SESSION['msg'] = "All Feilds Required";
				redirect(base_url() . "main/add");
			}
		}
		# End of Adding note Proc

		# requset is sent from Add-note form
		if($this->input->post("update")){
			$this->load->model('note_op');
			$this->form_validation->set_rules('title', 'title', 'required');
			$this->form_validation->set_rules('body', 'body', 'required');

			$data = array(
				'title' => $this->input->post("title"),
				'body' => $this->input->post("body"),
				'date' => date("M d, Y"),
				'id_user' => $_SESSION['id']
			);
			if($this->form_validation->run()){

				$id = $this->uri->segment(3);

				$this->note_op->update_note($data, $id);
				$_SESSION['msg'] = "Updated Successfully";
				redirect(base_url());

			} else {
				$_SESSION['msg'] = "All Feilds Required";
				redirect(base_url());
			}
		}
		# End of Adding note Proc
	}

	public function login(){
		if(isset($this->session->username)){
			redirect(base_url());
		}
		$this->load->view('login');
	}

	public function logout(){
		unset($_SESSION['id']);
		unset($_SESSION['username']);
		unset($_SESSION['fullname']);
		$this->index();
	}

	public function add(){
		if(!isset($this->session->username)){
			redirect(base_url());
		}
		$data['type'] = "add";
		$this->load->view('add_Edit', $data);
	}

	public function edit(){
		if(!isset($this->session->username)){
			redirect(base_url());
		}
		$note_id = $this->uri->segment(3);
		$this->load->model('note_op');
		$data['type'] = "edit";
		$data['note_data'] = $this->note_op->fetch_note($note_id, $_SESSION['id']);
		if(empty($data['note_data'])){
			redirect(base_url());
		}
		$this->load->view('add_Edit', $data);
	}

	public function delete(){
		if(!isset($this->session->username)){
			redirect(base_url());
		}
		$note_id = $this->uri->segment(3);
		$this->load->model('note_op');
		$this->note_op->delete_note($note_id);
		redirect(base_url());
	}

	public function note(){
		if(!isset($this->session->username)){
			redirect(base_url());
		}
		$note_id = $this->uri->segment(3);
		$this->load->model('note_op');
		$data['type'] = "note";
		$data['note_data'] = $this->note_op->fetch_note($note_id, $_SESSION['id']);
		if(empty($data['note_data'])){
			redirect(base_url());
		}
		$this->load->view('add_Edit', $data);
	}
}
