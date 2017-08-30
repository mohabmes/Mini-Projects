<?php
class Athun_system extends CI_Model{

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
}
