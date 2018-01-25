<?php
$title = "Login";
include('header.php');
?>

  <div class="container col-md-4 col-md-offset-4 well custm-bx">
    <h3 align="center">Login</h3>
    	<form method="post" action="<?=base_url();?>auth/login">
  			<div class="form-group">
  					<label>Enter Username</label>
  					<input type="text" name="username" class="form-control" />
  			 </div>
  			 <div class="form-group">
  					<label>Enter Password</label>
  					<input type="password" name="password" class="form-control" />
  			 </div>
  			 <div class="form-group">
  					<input type="submit" name="login" value="Login" class="btn btn-info" />
  			 </div>
    	</form>
  </div>
	</div>
</body>
</html>
