<!DOCTYPE html>
<html>
<head>
		<title><?=$title?></title>
		<?php echo link_tag('../assets/css/bootstrap.min.css'); ?>
		<style>

			.custm-bx{
				padding: 0 40px;
			}
			header{
				background-color:#44494e;
			}
			header a{
				color:white;
			}
			header p{
				color:white;
				padding-top: 15px;
			}
			header a:hover{
				color:black;
				text-decoration: underline;
			}
			.profile img{
				width: 100%;
				height: 200px;
				border-radius: 7px;
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
				margin-bottom: 20px;
			}


		</style>
	</head>
	<body>
	<header class="navbar navbar-static-top">
		<div class="container">
			<div class="navbar-header col-md-5">
				<a href="./" class="navbar-brand">Nota App</a>
			</div>

				<ul class="nav navbar-nav navbar-right">
					<?php if(!isset($_SESSION['id'])): ?>
						<li>
							<a href="<?=base_url()?>main/register">Register</a>
						</li>
						<li>
							<a href="<?=base_url()?>main/login">Login</a>
						</li>
					<?php else: ?>
						<li style="margin-right: 20px;">
							<p>Hello, <?=$_SESSION['fullname']?></p>
						</li>
						<li>
							<a href="<?=base_url()?>main/logout">Logout</a>
						</li>
					<?php endif; ?>
				</ul>
			</nav>
		</div>
	</header>
	<div class="container">
	<?php
		if(isset($_SESSION['msg'])){
			echo "<div class=\"bg-warning error\" >{$_SESSION['msg']}</div>";
			unset($_SESSION['msg']);
		}
	?>
