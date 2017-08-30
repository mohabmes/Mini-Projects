<?php
$title = "Register Now";
include('header.php');
?>

  <div class="container col-md-4 col-md-offset-4 well custm-bx">
		<h3 align="center">Register</h3>
	  	<form method="post" action="<?php echo base_url();?>main/form_validation">
				<div class="form-group">
						<label>Enter Full-name</label>
						<input type="text" name="fullname" class="form-control" />
						<span class="text-danger"><?php echo form_error("fullname")?></span>
				</div>
				<div class="form-group">
						<label>Enter Username</label>
						<input type="text" name="username" class="form-control" />
						<span class="text-danger"><?php echo form_error("username")?></span>
				</div>
				<div class="form-group">
						<label>Enter Password</label>
						<input type="password" name="password" class="form-control" />
						<span class="text-danger"><?php echo form_error("password")?></span>
				</div>
				<div class="form-group">
						<label>Enter Password Again</label>
						<input type="password" name="password_again" class="form-control" />
						<span class="text-danger"><?php echo form_error("password_again")?></span>
				</div>
				<div class="form-group">
						<input type="submit" name="register" value="Register" class="btn btn-info" />
				</div>
	  	</form>

	</div>
</div>
</body>
</html>
