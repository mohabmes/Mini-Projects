<?php
$title = "Payment";
include('header.php');
?>
<form method="post" action="<?=base_url();?>pay/add">
  <div class="container col-md-6 col-md-offset-3 well custm-bx">
    <h3 align="center">Payment Info</h3>
        <div class="form-group">
          <label>Full-Name</label>
          <input type="text" name="name" class="form-control" value="<?=$student->fname ." ". $student->lname?>" disabled>
        </div>
        <div class="form-group">
          <label>Phone</label>
          <input type="text" name="phone" class="form-control" value="<?=$student->phone?>" disabled>
        </div>
        <div class="form-group">
          <label>Course</label>
            <select class="form-control" name="course_id">
              <?php foreach($enrollment as $crs):?>
                 <option value="<?=$crs->courses_id?>"><?=$crs->title?></option>
             <?php endforeach;?>
            </select>
        </div>
        <div class="form-group">
          <label>Fees</label>
            <input type="text" name="fees" class="form-control">
            <p>Negative values will be treated as a return.</p>
        </div>
        <div class="form-group">
          <input type="hidden" name="student_id" class="form-control" value="<?=$this->uri->segment(3)?>">
          <input type="submit" name="Pay" value="Pay" class="btn btn-info" />
        </div>
      </form>
  </div>
</div>
