<?php
	require_once('inc/db.php');
	$header = "Login";
	require_once('inc/header.php');
	
	if(!empty($_COOKIE['user_id']) && !empty($_COOKIE['user_name']) && !empty($_COOKIE['username']) ){
		$_SESSION['user_id'] = $_COOKIE['user_id'];
		$_SESSION['username'] = $_COOKIE['username'];
		$_SESSION['user_name'] = $_COOKIE['user_name'];
	}
	
	if(isset($_SESSION['user_id'])){
		header('Location: index.php');
		die();
	}
	
	if(isset($_POST['login'])){
		
		//	//	//	//	//
		$user = new User();
		$user = $user->login($_POST['username'],$_POST['password']);
		//	//	//	//	//
		
		if(!empty($user)){
			
			$_SESSION['user_id'] = $user['id'];
			$_SESSION['username'] = $user['username'];
			$_SESSION['user_name'] = $user['first_name'] . " " . $user['last_name'];
			
			if(isset($_POST['remember'])){
				setcookie('user_id',$_SESSION['user_id'],time()+60*60*24*7);
				setcookie('username',$_SESSION['username'],time()+60*60*24*7);
				setcookie('user_name',$_SESSION['user_name'],time()+60*60*24*7);
			}
			
			header('Location: index.php');
			die();
			
		} else{
			header('Location: login.php?error=invalid username/password');
			die();
		}
	}
?>

	<div class="container">
	<div class="container col-md-4 col-md-offset-4 well custm-bx">
	<h3>Login</h3><br>
	<form class="form-horizontal" method="POST">		  
		  
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
			  <input type="checkbox" name="remember" id="remember" value="remember" placeholder="remember me">
			  <label for="remember">Remember me</label>
			</div>
		  </div>
		  
		  
		  <div class="form-group">
			<div class="col-sm-10">
			  <button type="submit" class="btn btn-primary" name="login">Login</button>
			</div>
		  </div>
		  
		</form>
	</div>
</div>