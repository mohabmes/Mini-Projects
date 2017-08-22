<?php
	@session_start();
	$header = "Home | ". $_SESSION['user_name'];
	require_once('inc/header.php');
	require_once('inc/db.php');
	
	if(!isset($_SESSION['user_id'])){
		header('Location: login.php');
	}
	
	$qry = $db->prepare('SELECT * FROM contact WHERE user_id=:id');
	
	$params = [
		'id' => $_SESSION['user_id']
	];
	$qry->execute($params);
	$result = $qry->fetchAll(PDO::FETCH_ASSOC);

?>
	<div class="container">
	<div class="bx">
		<a href="add.php" class="col-sm-1 btn btn-success">New</a>
		<h3 class="col-md-offset-5">My Contacts</h3>
	</div>
	<?php if(!empty($result)):?>
		<br><br>
		<table class="table table-condensed">
			<thead>
				<tr>
					<th>Image</th>
					<th>Name</th>
					<th>Email</th>
					<th>Mobile</th>
					<th>Country</th>
					<th>City</th>
					<th>Street</th>
					<th></th>
				</tr>
			</thead>
			<tbody>
			<?php foreach($result as $contact):?>
				<tr>
					<td>
						<?php
							$file = "./img/".$contact['name'].".jpg";
							$avatar = "img/avatar.jpg";
							if(is_file($file)){
								echo "<img src='$file'  height='55px' width='55px'>";
							} else {
								echo "<img src='$avatar'  height='55px' width='55px'>";
							}
						?>
					</td>
					<td><a href="update_contact.php?id=<?=$contact['id']?>"><?=$contact['name']?></a></td>
					<td><p><?=$contact['email']?></p></td>
					<td><p><?=$contact['mobile']?></p></td>
					<td><p><?=$contact['country']?></p></td>
					<td><p><?=$contact['city']?></p></td>
					<td><p ><?=$contact['street']?></p></td>
					<td><a href="delete.php?id=<?=$contact['id']?>">X</a></td>
				</tr>
			<?php endforeach;?>
			</tbody>
		</table>
	<?php else: ?>
		<div class="bg-info">No Contacts</div>
	<?php endif; ?>
	</div>
	</body>
</html>