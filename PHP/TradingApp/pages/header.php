<!DOCTYPE html>
<html>
<head>
		<title><?=$title?></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
	</head>
	<body>

  <div class="pb-2 mt-4 mb-2 border-bottom">
      <div class="container">
        TradingApp
        <?php if(isset($_COOKIE['auth_session']) && $auth->checksession($_COOKIE['auth_session']) ) :?>
          <a href="?page=logout" class="float-right ml-3">Logout</a>
          <a href="?page=home" class="float-right ml-3"><?=$session['username']?> Balance(<?=$userbalance?> $)</a>
        <?php else: ?>
          <a href="?page=login" class="float-right ml-3">Login</a>
          <a href="?page=register" class="float-right">Register</a>
       <?php endif; ?>
      </div>
</div>
<div class="container">
	<?php
		if(isset($_SESSION['alert_msg'])){
			if($_SESSION['alert_msg_type'] == 'error')
				echo "<div class='alert alert-danger'>{$_SESSION['alert_msg']}</div>";
			else
				echo "<div class='alert alert-info'>{$_SESSION['alert_msg']}</div>";
			unset($_SESSION['alert_msg']);
			unset($_SESSION['alert_msg_type']);
		}
		@print_r($_SESSION['alert_msg']);
	?>
