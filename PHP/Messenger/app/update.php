<?php
require_once('../core/init.php');

if(isset($_GET['username']) && isset($_GET['message'])){
  $username = htmlspecialchars($_GET['username']);
  $message = htmlspecialchars($_GET['message']);

  if(empty($username) || empty($message)){
    die();
  } else {
    $sql = "INSERT INTO messages VALUES ('', :username, :message)";
    $qry = $db->prepare($sql);
    $qry->execute([
      'username' => $username,
      'message' => $message
    ]);
  }
}
