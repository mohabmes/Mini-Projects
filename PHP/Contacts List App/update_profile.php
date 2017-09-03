<?php
require_once('inc/db.php');
$header = "My Profile";

require_once('inc/header.php');

if(!isset($_SESSION['user_id'])){
	header('Location: index.php');
	die();
}

if(is_file($file)){
	$pimgsrc = "./img/p".$_SESSION['user_id'].".jpg";
} else {
	$pimgsrc = "img/avatar.jpg";
}

//	//	//	//	//	//	//	
$user = new User();
$result = $user->getUser($_SESSION['user_id']);
//	//	//	//	//	//	//	

if(isset($_POST['update'])){
	if(!empty($_POST['fname']) && !empty($_POST['lname']) &&
		!empty($_POST['username']) && !empty($_POST['password']) && 
		!empty($_POST['password_again']) && isset($_POST['gender'])){
			
			if($_POST['password_again'] != $_POST['password']){
				header('Location: update_profile.php?error=Password Doesn\'t Match');
				die();
			}
			
			$params = [
				'first_name' => $_POST['fname'],
				'last_name' => $_POST['lname'],
				'gender' => $_POST['gender'],
				'username' => $_POST['username'],
				'password' => $_POST['password'],
				'id' => $_SESSION['user_id']
			];
			
			//	//	//	//	//
			$check = $user->update($_SESSION['user_id'],$params);
			//	//	//	//	//
			
			if($check){
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

<div class="col-md-3 profile">
	<img src='<?=$pimgsrc?>'>
</div>

<div class="col-md-9">
	<form class="form-horizontal" method="POST" enctype="multipart/form-data">
	
		<div class="form-group">
			<div>
			  <input type="text" class="form-control" id="fname" name="fname" placeholder="First Name" value="<?=$result['first_name']?>">
			</div>
		  </div>
		  
		  
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="lname" name="lname" placeholder="Last Name" value="<?=$result['last_name']?>">
			</div>
		  </div>
		  
		  <div class="form-group">
			<div class="radio">
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
			<div>
			  <input type="text" class="form-control" id="username" name="username" placeholder="Username" value="<?=$result['username']?>">
			</div>
		  </div>
		  
		  <div class="form-group">
			<div>
			  <input type="password" class="form-control" id="password" name="password" placeholder="Password">
			</div>
		  </div>
		  
		  <div class="form-group">
			<div>
			  <input type="password" class="form-control" id="password_again" name="password_again" placeholder="Password">
			</div>
		  </div>
		  
		  <div class="form-group">
			<div class="col-sm-10">
			  <button type="submit" class="btn btn-primary" name="update">Update</button>
			</div>
		  </div>
	  
	</form>
</div>
</div>