<?php
$title = "TradingApp - Register";
include('header.php');

if(!empty($_COOKIE['auth_session']))
	redirect_to('home');

if(!empty($_POST)){
		$res = $auth->register($_POST['username'], $_POST['password'], $_POST['verifypassword'], $_POST['email']);
		// echo $_POST['username'];
		// exit();
		if($res === true){
			set_alert_msg($res, '');
			redirect_to('register');
		}
		if($res !== true){

			set_alert_msg($res);
			redirect_to('register');
		}
	}
?>

<div class="container mx-auto" style="width:450px;">
<form method="post" action="?page=register">
<table class="center" border="0" cellspacing="5" cellpadding="5">
  <tr>
		<tr>
			<td><h3>Register</h3></td>
			<td></td>
		</tr>
    <td>Username :</td>
    <td><label for="username"></label>
    <input name="username" type="text" id="username" maxlength="30" /></td>
  </tr>
  <tr>
    <td>Password :</td>
    <td><label for="password"></label>
    <input name="password" type="password" id="password" maxlength="30" /></td>
  </tr>
  <tr>
    <td>Verify Password :</td>
    <td><label for="verifypassword"></label>
    <input name="verifypassword" type="password" id="verifypassword" maxlength="30" /></td>
  </tr>
  <tr>
    <td>Email :</td>
    <td><label for="email"></label>
    <input name="email" type="text" id="email" maxlength="100" /></td>
  </tr>
  <tr>
		<td></td>
    <td><br /><input type="submit" value="Register" /></td>
  </tr>
</table>
</form>
</div>
</div>
</body>
</html>
