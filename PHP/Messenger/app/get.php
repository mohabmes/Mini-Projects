<?php
require_once('../core/init.php');

$username = stripslashes(htmlspecialchars($_GET['username']));
$qry = $db->prepare("SELECT * FROM messages");
$qry->execute();
$result = $qry->fetchAll();

// var_dump($res);
foreach ($result as $key) {
  echo $key[1] . "\\" . $key[2] . "\n";
}
