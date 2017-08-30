<?php
$title = ($type == "add")? "Add New Note" : "Update";
include('header.php');
?>

  <div class="container col-md-6 col-md-offset-3 well custm-bx">
    <?php if($type=="add"):?>
  		<h3 align="center"><?=$title?></h3>
  	  	<form method="post" action="<?php echo base_url();?>main/form_validation">
  				<div class="form-group">
  						<label>Enter Title</label>
  						<input type="text" name="title" class="form-control">
  						<span class="text-danger"><?php echo form_error("title")?></span>
  				</div>
  				<div class="form-group">
  						<label>Enter Note Body</label>
              <textarea name="body" class="form-control" rows="15"></textarea>
  						<span class="text-danger"><?php echo form_error("username")?></span>
  				</div>
  				<div class="form-group">
              <input type="submit" name="add" value="Add" class="btn btn-info" />
            </div>
          </form>
    <?php elseif($type=="edit"):?>
      <h3 align="center"><?=$title?></h3>
  	  	<form method="post" action="<?php echo base_url();?>main/form_validation">
  				<div class="form-group">
  						<label>Enter Title</label>
  						<input type="text" name="title" class="form-control" value="<?=$note_data->title?>">
  				</div>
  				<div class="form-group">
  						<label>Enter Note Body</label>
              <textarea name="body" class="form-control" rows="15"><?=$note_data->body?></textarea>
  				</div>
  				<div class="form-group">
              <input type="submit" name="update" value="Update" class="btn btn-info" />
            </div>
          </form>
      <?php elseif($type=="note"):?>
        <h3 align="center"></h3>
          <form method="#" action="#">
            <div class="form-group">
                <label>Title</label>
                <input type="text" name="title" class="form-control" value="<?=$note_data->title?>" disabled>
            </div>
            <div class="form-group">
                <label>Date</label>
                <input type="text" name="date" class="form-control" value="<?=$note_data->date?>" disabled>
            </div>
            <div class="form-group">
                <label>Note Body</label>
                <textarea name="body" class="form-control" rows="15" disabled><?=$note_data->body?></textarea>
            </div>
            </form>
    <?php endif;?>
	</div>
</body>
</html>
