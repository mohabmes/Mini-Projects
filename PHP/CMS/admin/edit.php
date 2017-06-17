<?php
require '../app/start.php';

if (!empty($_POST)) {
	$id 		= filter_input(INPUT_POST, "id", FILTER_SANITIZE_STRING);
	$label 	= filter_input(INPUT_POST, "label", FILTER_SANITIZE_STRING);
	$title 	= filter_input(INPUT_POST, "title", FILTER_SANITIZE_STRING);
	$slug 	= filter_input(INPUT_POST, "slug", FILTER_SANITIZE_STRING);
	$body 	= filter_input(INPUT_POST, "body", FILTER_SANITIZE_SPECIAL_CHARS);

	$updatePage = $db->prepare("
		UPDATE pages SET
			label = :label,
			title = :title,
			slug = :slug,
			body = :body,
			updated = NOW()
		WHERE id = :id
	");
	$updatePage->execute([
		'id' => $id,
		'label' => $label,
		'title' => $title,
		'body' => $body,
		'slug' => $slug,
	]);
	header('Location: ' . BASE_URL . '/admin/list.php');
}

if (!isset($_GET['id'])) {
	header('Location: ' . BASE_URL . '/admin/list.php');
	die();
}

$page = $db->prepare("
	SELECT id, title, label, body, slug FROM pages
	WHERE id = :id
");
$page->execute(['id' => $_GET['id']]);
$page = $page->fetch(PDO::FETCH_ASSOC);

require VIEW_ROOT . '/admin/edit.php';
