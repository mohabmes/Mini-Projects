<?php
$header = "My Profile";

require_once('inc/header.php');
require_once('inc/db.php');

if(!isset($_SESSION['user_id'])){
	header('Location: index.php');
	die();
}
$qry = $db->prepare('SELECT * FROM users WHERE id=:id');

$params = [
	'id' => $_SESSION['user_id']
];
$qry->execute($params);
$result = $qry->fetch(PDO::FETCH_ASSOC);


if(isset($_POST['update'])){
	if(!empty($_POST['fname']) && !empty($_POST['lname']) &&
		!empty($_POST['username']) && !empty($_POST['password']) && 
		!empty($_POST['password_again']) && isset($_POST['gender'])){
			
			if($_POST['password_again'] != $_POST['password']){
				header('Location: update_profile.php?error=Password Doesn\'t Match');
				die();
			}
			
			$sql = 'UPDATE users SET first_name=:first_name, last_name=:last_name, gender=:gender, username=:username, password=:password WHERE id=:id';
			
			$qry = $db->prepare($sql);
			
			$params = [
				'first_name' => $_POST['fname'],
				'last_name' => $_POST['lname'],
				'gender' => $_POST['gender'],
				'username' => $_POST['username'],
				'password' => $_POST['password'],
				'id' => $_SESSION['user_id']
			];
			
			if($qry->execute($params)){
				$_SESSION['username']=$_POST['username'];
				$_SESSION['user_name']=$_POST['fname'].' '.$_POST['lname'];
				header('Location: update_profile.php?msg=Updated Successfully');
				die();
			}
			
		} else {
			header('Location: update_profile.php?error=All fields required');
			die();
		}
}

?>
<div class="container col-md-8 col-md-offset-2 well custm-bx">
	<div class="bx">
		<h3 class="col-md-offset-5">My Profile</h3>
	</div>

<br>
<?php
	$file = "./img/".$_SESSION['username'].".jpg";
	$avatar = "img/avatar.jpg";
	if(is_file($file)){
		echo "<img src='$file' class='col-md-offset-5'>";
	} else {
		echo "<img src='$avatar' class='col-md-offset-5'>";
	}
?><br><br>
<form class="form-horizontal" method="POST" enctype="multipart/form-data">
	<div class="form-group">
		<label for="fname" class="col-sm-2 control-label">First Name</label>
		<div class="col-sm-8">
		  <input type="text" class="form-control" id="fname" name="fname" placeholder="First Name" value="<?=$result['first_name']?>">
		</div>
	  </div>
	  
	  
	  <div class="form-group">
		<label for="lname" class="col-sm-2 control-label">Last Name</label>
		<div class="col-sm-8">
		  <input type="text" class="form-control" id="lname" name="lname" placeholder="Last Name" value="<?=$result['last_name']?>">
		</div>
	  </div>
	  
	  <div class="form-group">
		<label for="gender" class="col-sm-2 control-label">Gender</label>
		<div class="col-sm-8 radio">
			<label class="col-sm-4">
				<input type="radio" name="gender" value="Male" <?=($result['gender']=='Male')?'checked':'';?>>
				Male
			</label>
			<label class="col-sm-2">
				<input type="radio" name="gender" value="Female" <?=($result['gender']=='Female')?'checked':'';?>>
				Female
			</label>
		</div>
	  </div>

	  <div class="form-group">
		<label for="username" class="col-sm-2 control-label">Username</label>
		<div class="col-sm-8">
		  <input type="text" class="form-control" id="username" name="username" placeholder="Username" value="<?=$result['username']?>">
		</div>
	  </div>
	  
	  <div class="form-group">
		<label for="password" class="col-sm-2 control-label">Password</label>
		<div class="col-sm-8">
		  <input type="password" class="form-control" id="password" name="password" placeholder="Password">
		</div>
	  </div>
	  
	  <div class="form-group">
		<label for="password_again" class="col-sm-2 control-label">Password Again</label>
		<div class="col-sm-8">
		  <input type="password" class="form-control" id="password_again" name="password_again" placeholder="Password">
		</div>
	  </div>
	  
	  <div class="form-group">
		<div class="col-sm-offset-2 col-sm-10">
		  <button type="submit" class="btn btn-primary" name="update">Update</button>
		</div>
	  </div>
  
</form>
</div>