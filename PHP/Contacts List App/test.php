<?php
	session_start();
	if(!isset($_SESSION['user_id'])){
		header('Location: login.php');
		die();
	}
	if(isset($_POST['add'])){
		extract($_POST);
		
		//Add User
		$db = new PDO('mysql:host=127.0.0.1;dbname=contact', 'root');
		$qry = $db->prepare('INSERT INTO contacts( name, email, mobile, country, city, street, user_id) VALUES ( :name, :email, :mobile, :country, :city, :street, :user_id)');
		
		$params = [
			'name' => $_POST['name'],
			'email' => $_POST['email'],
			'mobile' => $_POST['mobile'],
			'country' => $_POST['country'],
			'city' => $_POST['city'],
			'street' => $_POST['street'],
			'user_id' => $_SESSION['user_id']
		];
		if(!$qry->execute($params)){
			header('Location: index.php?error=Something Went Wrong');
			die();
		} else {
			header('Location: index.php?error=Successfully Added');
			die();
		}
	}
?>
<html>
	<head>
		<title>Lab4</title>
		<link href="css/bootstrap.min.css" rel="stylesheet">
		<style>
			body{
				margin:15px 0;
			}
			.error{
				margin:10px 0;
				padding: 15px;
				text-align: center;
			}
		</style>
	</head>
	<body>
	<div class="container">
	<?php
		if(isset($_GET['error'])){
			echo "<p class=\"bg-warning col-sm-12 error\" >{$_GET['error']}</p>";
		}
	?>
	<form class="form-horizontal" method="POST">
		
		  <div class="form-group">
			<label for="name" class="col-sm-2 control-label">Name</label>
			<div class="col-sm-8">
			  <input type="text" class="form-control" id="name" name="name" placeholder="Name">
			</div>
		  </div>
		  
		  
		  <div class="form-group">
			<label for="email" class="col-sm-2 control-label">Email</label>
			<div class="col-sm-8">
			  <input type="email" class="form-control" id="email" name="email" placeholder="Email">
			</div>
		  </div>
		  
		  
		  <div class="form-group">
			<label for="mobile" class="col-sm-2 control-label">Mobile</label>
			<div class="col-sm-8">
			  <input type="text" class="form-control" id="mobile" name="mobile" placeholder="Mobile">
			</div>
		  </div>
		
		  
		  
		  <div class="form-group">
			<label for="country" class="col-sm-2 control-label">Country</label>
			<div class="col-sm-8">
			  <input type="text" class="form-control" id="country" name="country" placeholder="Country">
			</div>
		  </div>
		
		  
		  
		  <div class="form-group">
			<label for="city" class="col-sm-2 control-label">City</label>
			<div class="col-sm-8">
			  <input type="text" class="form-control" id="city" name="city" placeholder="City">
			</div>
		  </div>
				  
		<div class="form-group">
			<label for="street" class="col-sm-2 control-label">Street</label>
			<div class="col-sm-8">
			  <input type="text" class="form-control" id="street" name="street" placeholder="Street">
			</div>
		  </div>
		  
		  <div class="form-group">
			<div class="col-sm-offset-2 col-sm-10">
			  <button type="submit" class="btn btn-primary" name="add">Add</button>
			  <button type="reset" class="btn btn-warning">Reset</button>
			</div>
		  </div>
		  
		</form>
	</body>
</html>