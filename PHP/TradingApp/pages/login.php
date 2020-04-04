<?php
$title = "TradingApp - Login";
include('header.php');

if(!empty($_COOKIE['auth_session']))
	redirect_to('home');

if(!empty($_POST)){

	$res = $auth->login($_POST['username'], $_POST['password']);

	if($res !== true){
		set_alert_msg($res);
		redirect_to('login');
	}
}

?>

<body>
<div class="box">

	<div class="container mx-auto" style="width:450px;">


		<form method="post" action="?page=login">
		<table class="center" border="0" cellspacing="5" cellpadding="5">
			<tr>
		    <td><h3>Login</h3></td>
		    <td></td>
		  </tr>
			<tr>
		    <td>Username :</td>
		    <td><input name="username" type="text" maxlength="30" /></td>
		  </tr>
		  <tr>
		    <td>Password :</td>
		    <td><input name="password" type="password" maxlength="30" /></td>
		  </tr>
		  <tr>
				<td></td>
		    <td><br/><input type="submit" value="Login" /></td>
		    </tr>
		</table>

	</div>
</div>
</body>
</html>
