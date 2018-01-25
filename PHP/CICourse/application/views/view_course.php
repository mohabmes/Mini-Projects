<?php
$title = "Courses : " . $course_data->title;
include('header.php');
?>

<span class="highlight">Courses : <?=$course_data->title?>
	<span><a href="../edit/<?=$course_data->id?>">Edit</a></span>
</span>

<table class="table">
  <thead>
    <tr>
      <th>Fields</th>
			<th>Info</th>
    </tr>
  </thead>
  <tbody>

		<tr>
			<td>Title</td>
			<td><?=$course_data->title?></td>
		</tr>
		<tr>
			<td>Instructor</td>
			<td><?=$course_data->instructor?></td>
		</tr>
		<tr>
			<td>Start Date</td>
			<td><?=$course_data->start_date?></td>
		</tr>
		<tr>
			<td>End Date</td>
			<td><?=$course_data->end_date?></td>
		</tr>
		<tr>
			<td>Tags</td>
			<td><?=$course_data->tag?></td>
		</tr>
		<tr>
			<td>Additional Note</td>
			<td><?=nl2br($course_data->note)?></td>
		</tr>
		<tr>
			<td>Price</td>
			<td><?=$course_data->price?></td>
		</tr>
		<tr>
			<td>Num Seats</td>
			<td><?=$course_data->seats?></td>
		</tr>
		<tr>
			<td>Num of student Enrolled</td>
			<td><?=sizeof($student_data)?></td>
		</tr>


  </tbody>
</table>

	<span class="highlight">Students Enrolled : <?=$course_data->title?></span>
	<?php if(!empty($student_data)):?>
			<table class="table">
				<thead>
					<tr>
						<th>ID</th>
						<th>Full-name</th>
						<th>Phone</th>
						<th>Enrollment date</th>
						<th></th>
					</tr>
				</thead>
				<tbody>
				<?php foreach($student_data as $std):?>
					<tr>
						<td><a href="<?=base_url();?>students/view/<?=$std['sid']?>"><?=$std['sid']?></a></td>
						<td><a href="<?=base_url();?>students/view/<?=$std['sid']?>"><?=$std['fname']." ".$std['lname']?></a></td>
						<td><?=$std['phone']?></td>
						<td><?=$std['edate']?></td>
						<td>
							<form method="post" action="<?=base_url();?>enroll/unenroll/<?=$course_data->id?>">
								<input type="hidden" name="student_id" value="<?=$std['sid']?>">
								<input type="submit" name="Unenroll" value="Unenroll" class="btn-custm">
							</form>
						</td>
					</tr>
				<?php endforeach;?>
				</tbody>
			</table>
	<?php else:?>
		<div style="text-align:center; margin:70px 0;">No Enrollment Yet</div>
	<?php endif;?>

</span>

	</div>
</body>
</html>
