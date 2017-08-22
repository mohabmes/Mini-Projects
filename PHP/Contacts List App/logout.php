<?php
session_start();

$_SESSION['user_id'] = null;
$_SESSION['user_name'] = null;
$_SESSION['username'] = null;

setcookie('user_id',$_SESSION['user_id'],-1);
setcookie('username',$_SESSION['username'],-1);
setcookie('user_name',$_SESSION['user_name'],-1);


header('Location: login.php');