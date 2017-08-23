<?php
	require_once('inc/db.php');

	$header = "Register Now";
	require_once('inc/header.php');
	if(isset($_SESSION['user_id'])){
		header('Location: index.php');
		die();
	}

	$email_check = '/[a-z]+@[a-z]+\.[a-z]{3}$/';

	$password_check = '/[a-z0-9_\-*]+$/';

	$name_check = '/[a-zA-Z]+$/';

	if(isset($_POST['register'])){

		if($_POST['code'] == $_POST['code']){

			if(isset($_POST['fname']) && !empty($_POST['fname']) && 

				isset($_POST['lname']) && !empty($_POST['lname']) &&

				isset($_POST['username']) && !empty($_POST['username']) &&

				isset($_POST['password']) && !empty($_POST['password']) && 
				
				isset($_POST['password_again']) && !empty($_POST['password_again']) && 

				isset($_POST['gender'])){

					if($_POST['password_again'] != $_POST['password']){
						header('Location: register.php?error=Password Doesn\'t Match');
						die();
					}
					
					if(!preg_match($name_check, $_POST['username']) && strlen($_POST['username'])<4 ){
						header('Location: register.php?error=Invalid username');
						die();
					}
					
					if(!preg_match($password_check, $_POST['password']) && strlen($_POST['password'])>=8){
						header('Location: register.php?error=Invalid password');
						die();
					}
					
					if(!preg_match($name_check, $_POST['fname'])){
						header('Location: register.php?error=Invalid First Name');
						die();
					}
					
					if(!preg_match($name_check, $_POST['lname'])){
						header('Location: register.php?error=Invalid First Name');
						die();
					}
				
				//	//	//	//	//
				$user = new User();
				
				$params = [
					'first_name' => $_POST['fname'],
					'last_name' => $_POST['lname'],
					'gender' => $_POST['gender'],
					'username' => $_POST['username'],
					'type' => 1,
					'password' => $_POST['password']
				];
				
				$check = $user->register($params);
				//	//	//	//	//
				
				if($check){
					$imgname = $db->lastInsertId();
					if(!empty($_FILES['img']['tmp_name'])){
						if(substr($_FILES['img']['type'],0,5) == 'image'){
							move_uploaded_file($_FILES['img']['tmp_name'], "./img/p".$imgname.'.jpg');
						}
						else {
							header('Location: register.php?error=Image invalid');
							die();
						}
					}
					header('Location: login.php?msg=Signed up successfully, Please Login.');
					die();
				} else {
					header('Location: register.php?error=Something went wrong, please try again');
					die();
				}
				
				
			} else {
				header('Location: register.php?error=All fields required');
				die();
			}

		} else {
			header('Location: register.php?error=Wrong code, Try again');
			die();
		}
	}
	
?>

<div class="container">

<div class="container col-md-5 col-md-offset-3 well custm-bx">
<h3>Registeration</h3><br>
<form class="form-horizontal" method="POST" enctype="multipart/form-data">

  <div class="form-group">
	<div>
	  <input type="text" class="form-control" id="fname" name="fname" placeholder="First Name">
	</div>
  </div>
  
  
  <div class="form-group">
	<div>
	  <input type="text" class="form-control" id="lname" name="lname" placeholder="Last Name">
	</div>
  </div>
  
  <div class="form-group">
	<div>
	  <input type="file" id="img" name="img" placeholder="Upload Your image">
	</div>
  </div>

  <div class="form-group">
	<div class="radio">
		<label class="col-sm-4">
			<input type="radio" name="gender" value="Male">
			Male
		</label>
		<label class="col-sm-2">
			<input type="radio" name="gender" value="Female">
			Female
		</label>
	</div>
  </div>		  
  
  <div class="form-group">
	<div>
	  <input type="text" class="form-control" id="username" name="username" placeholder="Username">
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
	<div>
	  <p for="code" class="col-md-3"><?php echo $code = rand(999,10000);?></p>
	  <input type="text" class="col-sm-2 form-control" name="code" id="code" placeholder="Enter the code here">
	</div>
  </div>
  
  <input type="hidden" name="code" value="<?php=$code?>">

  <div class="form-group">
	<div class="col-sm-10">
	  <button type="submit" name="register" class="btn btn-primary">Sign Up</button>
	</div>
  </div>
	  
	</form>
</div>
