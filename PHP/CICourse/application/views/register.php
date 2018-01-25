<?php
$title = "Register";
include('header.php');
?>

<div class="container col-md-6 col-md-offset-3 well custm-bx">

  <h3 align="center">Add a new Admin</h3><br>

    <form method="post" action="<?=base_url()."auth/register"?>">

      <div class="form-group">
        <label>Username</label>
        <input type="text" name="username" class="form-control">
      </div>

      <div class="form-group">
        <label>Password</label>
        <input type="password" name="password" class="form-control">
      </div>

      <div class="form-group">
        <label>Type</label>
        <select class="form-control" name="type">
          <option value="1">Moderator</option>
          <option value="0">Administrator</option>
        </select>
      </div>

      <div class="form-group">
        <input type="submit" name="Register" value="Register" class="btn btn-info" />
      </div>

    </form>
	</div>

	</div>
</body>
</html>
