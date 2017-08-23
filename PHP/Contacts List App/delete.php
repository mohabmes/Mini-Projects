<?php
	require_once('inc/db.php');
	session_start();

	if(!isset($_SESSION['user_id'])){
		header('Location: login.php');
		die();
	}

	//	//	//	//	//
	$contact = new Contact();
	$delete = $contact->deleteContact($_GET['id']);
	//	//	//	//	//

	if($delete){
		header('Location: index.php?msg=Deleted successfully');
		die();
	} else {
		header('Location: index.php?error=Something went wrong');
		die();
	}