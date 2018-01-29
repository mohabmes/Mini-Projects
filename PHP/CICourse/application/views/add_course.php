<?php
$title = "Add a new Course";
if(isset($op_type)){
  $title = "Update " . $course_data->title;
}
include('header.php');
?>

<div class="container col-md-9 col-md-offset-2 well custm-bx">
  <h3 align="center"><?php if(isset($op_type)) echo "Update ";?>Course Info</h3>
    <form method="post" action="<?php if(isset($op_type)){echo base_url()."courses/edit/".$course_data->id;} else{echo base_url()."courses/add";}?>">
      <div class="form-group">
        <label>Enter Title</label>
        <input type="text" name="title" class="form-control" value="<?php if(isset($op_type)) echo $course_data->title?>">
      </div>
      <div class="form-group">
        <label>Enter Instructor Name</label>
        <input type="text" name="instructor" class="form-control"  value="<?php if(isset($op_type)) echo $course_data->instructor?>">
      </div>
      <div class="form-group">
        <label>Starting Date</label>
        <input type="date" name="start_date" class="form-control" value="<?php if(isset($op_type)) echo $course_data->start_date?>">
      </div>
      <div class="form-group">
        <label>End Date</label>
        <input type="date" name="end_date" class="form-control" value="<?php if(isset($op_type)) echo $course_data->end_date?>">
      </div>
      <div class="form-group">
        <label>Tag (separated by colon)</label>
        <input type="text" name="tag" class="form-control" value="<?php if(isset($op_type)) echo $course_data->tag?>">
      </div>
      <div class="form-group">
        <label>Additional Note</label><br>
        <textarea name="note" rows="8" cols="105"><?php if(isset($op_type)) echo $course_data->note?></textarea>
      </div>
	  	  
      <div class="form-group">
        <label>Price</label><br>
        <input type="text" name="price" class="form-control" value="<?php if(isset($op_type)) echo $course_data->price?>">
      </div>
      <div class="form-group">
        <label>Seats Num</label><br>
        <input type="text" name="seats" class="form-control" value="<?php if(isset($op_type)) echo $course_data->seats?>">
      </div>
      <?php if(!isset($op_type)):?>
        <div class="form-group">
          <input type="submit" name="Add" value="Add" class="btn btn-info" />
        </div>
      <?php if(!isset($op_type)):?>
        <div class="form-group">
          <input type="submit" name="Add" value="Add" class="btn btn-info" />
        </div>
      <?php else:?>
        <input type="hidden" name="id" value="<?=$course_data->id?>">
        <div class="form-group">
          <input type="submit" name="Update" value="Update" class="btn btn-info" />
        </div>
      <?php endif;?>
    </form>
	</div>

	</div>
</body>
</html>
