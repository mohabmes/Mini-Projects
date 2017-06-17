<?php
ini_set('display_errors', 'On');

define('APP_ROOT', __DIR__);
define('VIEW_ROOT', APP_ROOT . '\views');
define('BASE_URL', 'http://localhost/cms');

//echo APP_ROOT;

try{
  $db = new PDO("mysql:host=localhost;dbname=cms", 'root');
  $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
}
catch (Exception $e) {
		echo "Error : ".$e->getMessage();
}

require('function.php');
