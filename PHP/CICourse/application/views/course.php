<?php
$title = "All Courses";
include('header.php');
?>
<form method="get" action="<?=base_url();?>courses/search">
	<div class="form-group">
			<input type="text" name="s" class="form-control" placeholder="Search for course">
	 </div>
</form>

<span class="highlight">Courses<span><a href="./add">New Course</a></span></span>

<table class="table table-condensed">
  <thead>
    <tr>
      <th>id</th>
      <th>Title</th>
      <th>instructor</th>
      <th>start Date</th>
      <th>End Date</th>
      <th>Tags</th>
      <th>Note</th>
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
      <td><p></p></td>

    </tr>
  <?php endforeach;?>
  </tbody>
</table>


	</div>
</body>
</html>
