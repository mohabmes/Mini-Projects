<?php
$title = "Student : " . $student_data->fname . " " . $student_data->lname;
include('header.php');
?>


	<span class="highlight">Student : <?=$student_data->fname . " " . $student_data->lname?>
		<span><a href="../edit/<?=$student_data->id?>">Edit</a></span>
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
				<td>Firstname</td>
				<td><?=$student_data->fname?></td>
			</tr>
			<tr>
				<td>Lastname</td>
				<td><?=$student_data->lname?></td>
			</tr>
			<tr>
				<td>Phone</td>
				<td><?=$student_data->phone?></td>
			</tr>
			<tr>
				<td>Email</td>
				<td><?=$student_data->email?></td>
			</tr>
			<tr>
				<td>Address</td>
				<td><?=$student_data->address?></td>
			</tr>

			<tr>
				<td>Num of Courses Enrolled</td>
				<td><b><?=sizeof($course_data)?></b></td>
			</tr>

			<tr>
				<td>Added on</td>
				<td><?=$student_data->added?></td>
			</tr>
	  </tbody>
	</table>
</div>

<div class="container #Enrollment">
		<span class="highlight">Courses Enrolled<span><a href="<?=base_url();?>enroll/add/<?=$student_data->id?>">New Enrollment</a></span></span>
			<?php if(!empty($course_data)):?>
					<table class="table">
					  <thead>
					    <tr>
					      <th>ID</th>
								<th>Course name</th>
								<th>Enrollment date</th>
								<th></th>
					    </tr>
					  </thead>
					  <tbody>
						<?php foreach($course_data as $crs):?>
							<tr>
								<td><a href="<?=base_url();?>courses/view/<?=$crs['cid']?>"><?=$crs['cid']?></a></td>
					      <td><a href="<?=base_url();?>courses/view/<?=$crs['cid']?>"><?=$crs['ctitle']?></a></td>
								<td><?=$crs['edate']?></td>
								<td>
									<form method="post" action="<?=base_url();?>enroll/unenroll/<?=$crs['cid']?>">
										<input type="hidden" name="student_id" value="<?=$student_data->id?>">
										<input type="submit" name="Unenroll" value="Unenroll" class="btn-custm">
									</form>
								</td>
							</tr>
			  		<?php endforeach;?>
					  </tbody>
					</table>
			<?php else:?>
				<div style="text-align:center; margin:70px 0;">Didn't Enroll Any Course Yet</div>
			<?php endif;?>
</div>

<div class="container #Enrollment">
		<span class="#Payment highlight">Payment<span><a href="<?=base_url();?>pay/add/<?=$student_data->id?>">New Payment</a></span></span>
		<?php if(!empty($paid_data)):?>
			<?php foreach($paid_data as $k=> $v):?>
				<?php foreach($payment_data as $pk=> $pv){
					if($pv->title == $k){
						$price = $pv->price;
						$cid = $pv->id;
					}
				}
				?>
				<table class="table table-bordered">
				  <thead>
				    <tr>
				      <th>ID</th>
							<th>Course</th>
							<th>Price</th>
							<th>Paid</th>
							<th>Residual</th>
				    </tr>
				  </thead>
				  <tbody>

						<tr>
							<td><?=$cid?></td>
							<td><?=$k?></td>
							<td><?=$price?></td>
							<td><?=$v?></td>
							<td><?=$price-$v?></td>
						</tr>
					</tbody>
				</table>

		</table><br>
			<?php endforeach;?>

		<?php else:?>
			<div style="text-align:center; margin:70px 0;">No Payment History Yet</div>
		<?php endif;?>
</div>

<div class="container #Enrollment">
		<span class="highlight">Payment History</span>
		<?php if(!empty($paid_data)):?>
			<?php foreach($paid_data as $k=> $v):?>

				<b><?=$k?></b>
				<table class="table table-bordered table-hover">
					<thead>
						<tr>
							<th>Code</th>
							<th>Amount</th>
							<th>Date</th>
							<th>Admin</th>
						</tr>
					</thead>
				  <tbody>


				<?php foreach($payment_data as $pk=> $pv):?>
					<?php if($pv->title == $k):?>
						<tr class=\"table-active\">
							<td>
									<?=($pv->fees>0?"++ ":"- - ")?>
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
					<?php endif;?>
				<?php endforeach;?>

			</tbody>
		</table><br>
			<?php endforeach;?>

		<?php else:?>
			<div style="text-align:center; margin:70px 0;">No Payment History Yet</div>
		<?php endif;?>
</div>

</body>
</html>
