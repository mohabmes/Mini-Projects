<?php
$title = "Search : $key";
include('header.php');
?>
<form method="get" action="<?php echo base_url(), $op;?>/search">
	<div class="form-group">
			<input type="text" name="s" class="form-control" placeholder="Search for <?=$op?>" value="<?=$this->input->get("s")?>">
	 </div>
</form>

<?php if($op == "courses"):?>
    <span class="highlight">Courses : "<?=$key?>"</span>
    <?php if(!empty($course_data)):?>
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
        <?php foreach($course_data as $crs):?>
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
    <?php else:?>
      <div style="text-align:center; margin:70px 0;">No Results Found</div>
    <?php endif;?>

<?php elseif($op == "students"):?>
      <span class="highlight">Students : "<?=$key?>"</span>
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
        <?php foreach($student_data as $std):?>
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
<?php endif;?>
	</div>
</body>
</html>
