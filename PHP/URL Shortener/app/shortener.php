<?php
class Shortener{

  protected $db;

  public function __construct(){
    $this->db = new PDO('mysql:host=Localhost; dbname=url', 'root');
  }
  
  public function generateCode($num){
    return base_convert($num, 10, 36);
  }

  public function makeCode($url){
    $url = trim($url);

    if(!filter_var($url, FILTER_VALIDATE_URL)){
      return false;
    }

    //escape char
    $url = $this->db->quote($url);

    //Check if exist
    $url_query = $this->db->query("SELECT code FROM links WHERE url=$url");

    if($url_query->rowCount()){
      $res = $url_query->fetch(PDO::FETCH_NUM);
      return $res[0];
    }
    else{
      //Add url & date
      $this->db->query("INSERT INTO links (url, created) VALUES ( $url, NOW() )");

      //gererate the code
      $code = $this->generateCode($this->db->lastInsertId());

      //Add the Code
      $this->db->query("UPDATE links SET code='$code' WHERE url=$url");

      return $code;
    }
  }

  public function getUrl($code){
    $code = $this->db->quote($code);
    $url_query = $this->db->query("SELECT url FROM links WHERE code=$code");
    if($url_query->rowCount()){
      $url = $url_query->fetch(PDO::FETCH_NUM);
      return $url[0];
    }
  }
}
?>
