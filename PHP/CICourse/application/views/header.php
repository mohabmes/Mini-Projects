<!DOCTYPE html>
<html>
<head>
		<title><?=$title?></title>
		<?=link_tag('../assets/css/bootstrap.min.css');?>
		<style>

			.custm-bx{
				padding: 0 40px;
			}
			.btn-custm{
				background-color: none;
				padding: 0;
				border: none;
				color: blue;
			}
			.btn-custm:hover{
				text-decoration: underline;
			}
			header{
				background-color:#000;
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
			header .navbar-brand:hover{
				color: white;
				text-decoration: underline;
			}
			header .navbar-icon{
				color: gray;
				transform: rotate(90deg);
			}
			header .navbar-icon:hover{
				text-decoration: none;
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
			.sidenav {
			    height: 100%; /* 100% Full-height */
			    width: 0; /* 0 width - change this with JavaScript */
			    position: fixed; /* Stay in place */
			    z-index: 1; /* Stay on top */
			    top: 0;
			    left: 0;
			    background-color: #111; /* Black*/
			    overflow-x: hidden; /* Disable horizontal scroll */
					padding: 8px 0 8px 0;
			    padding-top: 60px;
			    transition: 0.15s; /* 0.5 second transition effect to slide in the sidenav */
			}

			/* The navigation menu links */
			.sidenav a {
				padding: 8px 0 8px 15px;
		    text-decoration: none;
		    font-size: 20px;
		    color: #818181;
		    display: block;
		    transition: 0.3s
			}
			.sidenav .info{
				padding: 5px 0;
				border-bottom: 1px solid gray;
				margin: 15px 15px 25px 15px;

			}
			.sidenav .info span {
				text-align: center;
				padding: 0 0  10px 0;
				font-size: 15px;
				color: #818181;
				display: block;
				transition: 0.3s
			}
			/* When you mouse over the navigation links, change their color */
			.sidenav a:hover, .offcanvas a:focus{
			    color: #f1f1f1;
			}

			/* Position and style the close button (top right corner) */
			.sidenav .closebtn {
		    position: absolute;
		    top: 0;
		    right: 25px;
		    font-size: 36px;
		    margin-left: 50px;
			}

			.highlight, .highlight2{
				display: block;
				color: white;
				background-color: red;
				opacity: 0.5;
				margin: 0 0 20px 0;
				padding: 12px 10px;
				font-size: 1.125em;
				border-radius: 2px;
			}

			.highlight span{
				float: right;
				color: blue;
				background-color: green;
				padding: 2px 15px;
			}
			.highlight span a{
				color: white;
			}
			.highlight2{
				background-color: grey;
				opacity: 0.7;
			}
			.highlight3{
				background-color: green;
				opacity: 0.7;
			}
			.icon{
				margin: 0 0 5px 0;
				font-size: 1.1125em;
			}
		</style>
		<script>
			function openNav() {
			    document.getElementById("mySidenav").style.width = "250px";
			    document.getElementsByClassName("container").style.marginLeft = "200px";
			}


			function closeNav() {
			    document.getElementById("mySidenav").style.width = "0";
			    document.getElementsByClassName("container").style.marginLeft = "0";
			    document.body.style.backgroundColor = "white";
			}


			function toggleNav() {
				var ms = document.getElementById("mySidenav").style.width;

				if(ms == "0px" || ms == 0)
					openNav()

				if(ms == "250px")
					closeNav()

			}
		</script>
	</head>
	<body>
	<header class="navbar navbar-static-top">
		<div class="container">

			<div class="navbar-header col-md-5">
				<?php if(isset($_SESSION['id'])): ?>
					<a  class="navbar-brand navbar-icon" onclick="toggleNav()">|||</a>
				<?php endif;?>
				<a href="<?=base_url()?>" class="navbar-brand">CICourse</a>
			</div>
			<?php if(isset($_SESSION['id'])): ?>
				<ul class="nav navbar-nav navbar-right">
					<?php if(!isset($_SESSION['id'])): ?>
						<li>
							<a href="<?=base_url()?>">Login</a>
						</li>
					<?php else: ?>
						<li style="margin-right: 20px;">
							<p>Hello, <?=$_SESSION['username']?></p>
						</li>
					<?php if($_SESSION['type'] == 0): ?>
						<li>
							<a href="<?=base_url()?>auth/register">Add a new Admin</a>
						</li>
					<?php endif; ?>
						<li>
							<a href="<?=base_url()?>auth/logout">Logout</a>
						</li>
					<?php endif; ?>
				</ul>
			<?php endif;?>
			</nav>
		</div>
	</header>

	<div id="mySidenav" class="sidenav">
		<div class="info">
			<span><?=$_SESSION['username']?></span>
		  <span>Signed in as a<?=($_SESSION['type']==0?"n Admin":" Mandator")?></span>
		</div>
		<?php if($_SESSION['type'] == 0): ?>
	  	<a href="<?=base_url()?>auth/view">Users</a>
		<?php endif; ?>
	  <a href="<?=base_url()?>courses/">Courses</a>
	  <a href="<?=base_url()?>students/">Students</a>
	</div>

	<div class="container">
	<?php
		if(isset($_SESSION['msg'])){
			echo "<div class='bg-warning error'>{$_SESSION['msg']}</div>";
			unset($_SESSION['msg']);
		}
	?>
