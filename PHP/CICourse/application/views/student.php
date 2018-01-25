<?php
$title = "All Students";
include('header.php');
?>
<form method="get" action="<?=base_url();?>students/search">
	<div class="form-group">
			<input type="text" name="s" class="form-control" placeholder="Search for student">
	 </div>
</form>

<span class="highlight">Students<span><a href="./add">New Student</a></span></span>

<table class="table table-condensed">
  <thead>
    <tr>
      <th>id</th>
      <th>First Name</th>
      <th>Second Name</th>
			<th>Email</th>
      <th>Phone</th>
      <th>Address</th>
      <th></th>
      <th></th>
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
      <td><a href="<?=base_url();?>enroll/add/<?=$std['id']?>">Enrollment</a></td>
			<td><a href="<?=base_url();?>pay/add/<?=$std['id']?>">Payment</a></td>
      <td><p></p></td>

    </tr>
  <?php endforeach;?>
  </tbody>
</table>


	</div>
</body>
</html>
