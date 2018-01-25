<?php
class Auth_model extends CI_Model{

  # inserting user
  public function insert_user($data = array()){
    $check = $this->db->insert('users', $data);
    if($check){
      return true;
    }
    return false;
  }

  # fetch user data
  public function fetch_user($data = array()){
    $this->db->where("username", $data['username']);
    $this->db->where("password", $data['password']);
    $query = $this->db->get("users");
    return $query->first_row();
  }

  public function fetch_All(){
    $this->db->select('*');
    $this->db->from('users');

    $query = $this->db->get();
    return $query->result();
  }

  public function rm($id){
    $this->db->where('id', $id);
    $this->db->delete('users');

  }
}
