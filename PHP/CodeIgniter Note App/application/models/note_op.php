<?php
class Note_op extends CI_Model{
  public function fetch_user_notes($id){
    $this->db->where("id_user", $id);
    $query = $this->db->get("notes");
    return $query;
  }

  public function insert_note($data = array()){
    $check = $this->db->insert('notes', $data);
    if($check){
      return true;
    }
    return false;
  }

  public function fetch_note($id, $id_user){
    $this->db->where("id_user", $id_user);
    $this->db->where("id", $id);
    $query = $this->db->get("notes");
    return $query->first_row();
  }

  function update_note($data, $id){
    $this->db->where("id", $id);
    $this->db->update("notes", $data);
  }

  function delete_note($id){
    $this->db->where("id", $id);
    $this->db->delete("notes");
  }
}
