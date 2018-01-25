<?php
$title = "Add a new Student";
if(isset($op_type)){
  $title = "Update " . $student_data->fname . " " . $student_data->lname;
}
include('header.php');
?>

<div class="container col-md-9 col-md-offset-2 well custm-bx">
  <h3 align="center"><?php if(isset($op_type)) echo "Update ";?>Student Info</h3>
    <form method="post" action="<?php if(isset($op_type)){echo base_url()."students/edit/".$student_data->id;} else{echo base_url()."students/add";}?>">
      <div class="form-group">
        <label>First-name *</label>
        <input type="text" name="fname" class="form-control" value="<?php if(isset($op_type)) echo $student_data->fname?>">
      </div>
      <div class="form-group">
        <label>Last-name *</label>
        <input type="text" name="lname" class="form-control"  value="<?php if(isset($op_type)) echo $student_data->lname?>">
      </div>
      <div class="form-group">
        <label>Email</label>
        <input type="email" name="email" class="form-control"  value="<?php if(isset($op_type)) echo $student_data->email?>">
      </div>
      <div class="form-group">
        <label>Phone *</label>
        <input type="text" name="phone" class="form-control" value="<?php if(isset($op_type)) echo $student_data->phone?>">
      </div>
      <div class="form-group">
        <label>Address</label>
        <input type="text" name="address" class="form-control" value="<?php if(isset($op_type)) echo $student_data->address?>">
      </div>

      <?php if(!isset($op_type)):?>
        <div class="form-group">
          <input type="submit" name="Add" value="Add" class="btn btn-info" />
        </div>
      <?php else:?>
        <input type="hidden" name="id" value="<?=$student_data->id?>">
        <div class="form-group">
          <input type="submit" name="Update" value="Update" class="btn btn-info" />
        </div>
      <?php endif;?>
    </form>
	</div>

	</div>
</body>
</html>
