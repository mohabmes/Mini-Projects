<?php
session_start();
require_once('inc/db.php');

if(!isset($_SESSION['user_id'])){
	header('Location: login.php');
	die();
}

$qry = $db->prepare('DELETE FROM contact WHERE id = :id');
			
$params = [
	'id' => $_GET['id']
];

if($qry->execute($params)){
	header('Location: index.php?msg=Deleted successfully');
	die();
} else {
	header('Location: index.php?error=Something went wrong');
	die();
}