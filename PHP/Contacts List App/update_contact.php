<?php
$header = "Update";

require_once('inc/header.php');
require_once('inc/db.php');

if(!isset($_SESSION['user_id'])){
	header('Location: index.php');
	die();
}

$qry = $db->prepare('SELECT * FROM contact WHERE id=:id AND user_id=:user_id');

$params = [
	'id' => $_GET['id'],
	'user_id' => $_SESSION['user_id'],
];
$qry->execute($params);
$result = $qry->fetch(PDO::FETCH_ASSOC);

if(empty($result) || $result['user_id']!=$_SESSION['user_id']){
	header('Location: index.php?error=Contact doesn\'t exist');
	die();
}

if(isset($_POST['update'])){
	if(!empty($_POST['name']) && !empty($_POST['email']) &&
		!empty($_POST['mobile'])){

		$sql = 'UPDATE contact SET name=:name, email=:email, mobile=:mobile, country=:country, city=:city, street=:street WHERE id=:id';

		$qry = $db->prepare($sql);

		$params = [
			'name' => $_POST['name'],
			'email' => $_POST['email'],
			'mobile' => $_POST['mobile'],
			'country' => $_POST['country'],
			'city' => $_POST['city'],
			'street' => $_POST['street'],
			'id' => $_GET['id']
		];
			
			
		if($qry->execute($params)){
			header('Location: index.php?msg=Updated Successfully');
			die();
		} else {
			header('Location: index.php?error=Something Went wrong');
			die();
		}
	} else {
		header("Location: $_SERVER[REQUEST_URI]&error=Some fields required");
		die();
	}
}

?>
<div class="container">
	
	<div class="container col-md-5 col-md-offset-3 well custm-bx">
	<h3>Update Contact</h3><br>
	<form class="form-horizontal" method="POST">
		
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="name" name="name" placeholder="Name *" value="<?=@$result['name']?>">
			</div>
		  </div>
		  
		  
		  <div class="form-group">
			<div>
			  <input type="email" class="form-control" id="email" name="email" placeholder="Email *" value="<?=@$result['email']?>">
			</div>
		  </div>
		  
		  
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="mobile" name="mobile" placeholder="Mobile *" value="<?=@$result['mobile']?>">
			</div>
		  </div>
		
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="country" name="country" placeholder="Country" value="<?=@$result['country']?>">
			</div>
		  </div>
		
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="city" name="city" placeholder="City" value="<?=@$result['city']?>">
			</div>
		  </div>
				  
		<div class="form-group">
			<div>
			  <input type="text" class="form-control" id="street" name="street" placeholder="Street" value="<?=@$result['street']?>">
			</div>
		  </div>

		  
		  <div class="form-group">
			<div>
			  <button type="submit" class="btn btn-primary" name="update">Update</button>
			</div>
		  </div>
		  
		</form>
	</body>
</html>