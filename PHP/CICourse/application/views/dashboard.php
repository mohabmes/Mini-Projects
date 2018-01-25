<?php
$title = "Dashboard";
include('header.php');
?>
<span class="highlight highlight3">Search</span>
<form method="get" action="<?=base_url();?>courses/search">
  <div class="form-group">
      <input type="text" name="s" class="form-control" placeholder="Search for course">
   </div>
</form>
<form method="get" action="<?=base_url();?>students/search">
	<div class="form-group">
			<input type="text" name="s" class="form-control" placeholder="Search for student">
	 </div>
</form>

<span class="highlight highlight3">Shortcuts</span>
  <ul class="mab">
    <li class="icon"><a href="<?=base_url()?>courses/add">New Course</a></li>
    <li class="icon"><a href="<?=base_url()?>students/add">New Student</a></li>
    <li class="icon"><a href="<?=base_url()?>courses/">View All Courses</a></li>
    <li class="icon mab"><a href="<?=base_url()?>students/">View All Students</a></li>
  </ul>

<span class="highlight highlight3">Latest Created Courses</span>
<table class="table table-bordered table-hover">
  <thead>
    <tr>
      <th>id</th>
      <th>Title</th>
      <th>instructor</th>
      <th>start Date</th>
      <th>End Date</th>
      <th>Tags</th>
    </tr>
  </thead>
  <tbody>
  <?php foreach($course as $crs):?>
    <tr>
      <td><a href="<?=base_url();?>courses/view/<?=$crs['id']?>"><?=$crs['id']?></a></td>
      <td><a href="<?=base_url();?>courses/view/<?=$crs['id']?>"><?=$crs['title']?></a></td>
      <td><p><?=$crs['instructor']?></p></td>
      <td><p><?=$crs['start_date']?></p></td>
      <td><p><?=$crs['end_date']?></p></td>
      <td><p><?=$crs['tag']?></p></td>
    </tr>
  <?php endforeach;?>
  </tbody>
</table>


<span class="highlight highlight3">Latest Added Students</span>
<table class="table table-bordered table-hover">
  <thead>
    <tr>
      <th>id</th>
      <th>First Name</th>
      <th>Second Name</th>
			<th>Email</th>
      <th>Phone</th>
      <th>Address</th>
    </tr>
  </thead>
  <tbody>
  <?php foreach($student as $std):?>
    <tr>
      <td><a href="<?=base_url();?>students/view/<?=$std['id']?>"><?=$std['id']?></a></td>
      <td><a href="<?=base_url();?>students/view/<?=$std['id']?>"><?=$std['fname']?></a></td>
      <td><a href="<?=base_url();?>students/view/<?=$std['id']?>"><?=$std['lname']?></a></td>
			<td><p><?=$std['email']?></p></td>
      <td><p><?=$std['phone']?></p></td>
      <td><p><?=$std['address']?></p></td>
    </tr>
  <?php endforeach;?>
  </tbody>
</table>


<span class="highlight highlight3">Latest Enrollments</span>
<table class="table table-bordered table-hover">
  <thead>
    <tr>
      <th>Student</th>
      <th>Course name</th>
      <th>Enrollment date</th>
    </tr>
  </thead>
  <tbody>
  <?php foreach($course_data as $crs):?>
    <tr>
      <td><?=$crs['fname'] ." ". $crs['lname']?></td>
      <td><?=$crs['title']?></td>
      <td><?=$crs['date']?></td>
    </tr>
  <?php endforeach;?>
  </tbody>
</table>

<span class="highlight highlight3">Latest Payments</span>
<table class="table table-bordered table-hover">
  <thead>
    <tr>
      <th>Code</th>
      <th>Student name</th>
      <th>Course</th>
      <th>Amount</th>
      <th>Date</th>
      <th>Admin</th>
    </tr>
  </thead>
  <tbody>
  <?php foreach($payment_data as $pk=> $pv):?>
      <tr class="table table-bordered table-hover">
        <td>
            <?=($pv->fees>0?"++ ":"- - ")?>
        </td>
        <td>
            <?=$pv->fname." " .$pv->lname?>
        </td>
        <td>
            <?=$pv->title?>
        </td>
        <td>
          <b><?=$pv->fees?></b>
        </td>
        <td>
          <b><?=$pv->date?></b>
        </td>
        <td>
          <b><?=$pv->username?></b>
        </td>

      </tr>
  <?php endforeach;?>
</tbody>
</table>
