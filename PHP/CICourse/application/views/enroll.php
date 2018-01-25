<?php
$title = "Enroll";
include('header.php');
?>
<form method="post" action="<?=base_url();?>enroll/add">
  <div class="container col-md-6 col-md-offset-3 well custm-bx">
    <h3 align="center">Erollment Info</h3>
        <div class="form-group">
          <label>Full-Name</label>
          <input type="text" name="name" class="form-control" value="<?=$student_data->fname ." ". $student_data->lname?>" disabled>
        </div>
        <div class="form-group">
          <label>Phone</label>
          <input type="text" name="phone" class="form-control" value="<?=$student_data->phone?>" disabled>
        </div>
        <div class="form-group">
          <label>Course</label>
            <select class="form-control" name="course_id">
              <option></option>
              <?php foreach($course_data as $crs):?>
                 <option value="<?=$crs['id']?>"><?=$crs['title']?></option>
             <?php endforeach;?>
            </select>
        </div>
        <div class="form-group">
          <input type="hidden" name="student_id" class="form-control" value="<?=$this->uri->segment(3)?>">
          <input type="submit" name="Add" value="Add" class="btn btn-info" />
        </div>
      </form>
  </div>
</div>
