<?php
require '../app/start.php';

if (!empty($_POST)) {
	$label 	= filter_input(INPUT_POST, "label", FILTER_SANITIZE_STRING);
	$title 	= filter_input(INPUT_POST, "title", FILTER_SANITIZE_STRING);
	$slug 	= filter_input(INPUT_POST, "slug", FILTER_SANITIZE_STRING);
	$body 	= filter_input(INPUT_POST, "body", FILTER_SANITIZE_SPECIAL_CHARS);

	$insertPage = $db->prepare("
		INSERT INTO pages (label, title, slug, body, created)
		VALUES (:label, :title, :slug, :body, NOW())
	");
	$insertPage->execute([
		'label' => $label,
		'title' => $title,
		'slug' 	=> $slug,
		'body' 	=> $body,
	]);
	header('Location: ' . BASE_URL . '/admin/list.php');
}
require VIEW_ROOT . '/admin/add.php';
