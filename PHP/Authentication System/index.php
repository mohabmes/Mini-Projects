<?php
require_once('core/init.php');

if(Session::exists(Config::get('session/session_name'))){
  echo '<a href="logout.php">Logout</a>';
}
else {
  echo 'Please <a href="login.php">login</a> OR <a href="register.php">register</a>';
}
