<?php
	@session_start();
?>
<html>
	<head>
		<title><?=$header?></title>
		<link href="css/bootstrap.min.css" rel="stylesheet">
		<style>
			.custm-bx{
				padding:0 30px;
			}
			header{
				background-color:#44494e;
			}
			header a{
				color:white;
			}
			header a:hover{
			color:white;
				text-decoration: underline;
			}
			.error, .bg-info{
				padding: 15px;
				margin: 15px 0;
			}
			.navbar-nav li h5{
				margin: 20px 0 0 15px;
			}
			.navbar-nav li img{
				margin: 5px 0;
				border-radius:50%;
				width: 40px;
				height:40px;
			}
			.bx{
				padding-bottom:15px;
				border-bottom : 1px solid #aaa;
			}

		</style>
	</head>
	<body>
	<header class="navbar navbar-static-top">
		<div class="container">
			<div class="navbar-header col-md-5">
				<a href="./" class="navbar-brand">Contact List</a>
			</div>
			
			<?php if(isset($_SESSION['user_id'])): ?>
			<nav class="navbar-collapse">
				<ul class="nav navbar-nav ">
					<li>
					<?php
						$file = "./img/".$_SESSION['username'].".jpg";
						$avatar = "img/avatar.jpg";
						if(is_file($file)){
							echo "<img src='$file'>";
						} else {
							echo "<img src='$avatar'>";
						}
					?>
					</li>
					<li>
						<h5><a href="update_profile.php"><?= $_SESSION['user_name']?></a></h5>
					</li>
				</ul>
			<?php endif; ?>
				<ul class="nav navbar-nav navbar-right">
					<?php if(!isset($_SESSION['user_id'])): ?>
						<li>
							<a href="register.php">Register</a>
						</li>
						<li>
							<a href="login.php">Login</a>
						</li>
					<?php else: ?>
						<li>
							<a href="logout.php">Logout</a>
						</li>
					<?php endif; ?>
				</ul>
			</nav>
		</div>
	</header>
	<div class="container">
	<?php
	if(isset($_GET['error'])){
		echo "<p class=\"bg-warning col-sm-12 error\" >{$_GET['error']}</p>";
	}
	if(isset($_GET['msg'])){
		echo "<p class=\"bg-success col-sm-12 error\" >{$_GET['msg']}</p>";
	}
	?>
	</div>