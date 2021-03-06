<?php
	require_once('inc/db.php');
	$header = "Add new contact";
	require_once('inc/header.php');

	if(!isset($_SESSION['user_id'])){
		header('Location: login.php');
		die();
	}

	
	if(isset($_POST['add'])){
		if(!empty($_POST['name']) && !empty($_POST['mobile']) ){
			
			//	//	//	//	//	//	//
			$contact = new Contact();
			
			$params = [
				'name' => $_POST['name'],
				'email' => $_POST['email'],
				'mobile' => $_POST['mobile'],
				'country' => $_POST['country'],
				'city' => $_POST['city'],
				'street' => $_POST['street']
			];
			
			$create = $contact->addContact($_SESSION['user_id'],$params );
			//	//	//	//	//	//	//

			if(!$create){
				header('Location: index.php?error=Something Went Wrong');
				die();
			} else {
				
				if(!empty($_FILES['img']['tmp_name'])){
					if(substr($_FILES['img']['type'],0,5) == 'image'){
						$imgname = $db->lastInsertId();
						if(!move_uploaded_file($_FILES['img']['tmp_name'], "./img/". $imgname .'.jpg')){
							header('Location: add.php?error=Something Wrong With The Image');
							die();
						}
					}
					else {
						header('Location: add.php?error=Invalid Image');
						die();
					}
				}
				
				header('Location: index.php?msg=Successfully Added');
				die();
			}
				
		} else {
			header('Location: add.php?error=All Fields Required');
			die();
		}
		
	}
	
?>
	<div class="container">
	
	<div class="container col-md-5 col-md-offset-3 well custm-bx">
	<h3>Add New Contact</h3><br>
	<form class="form-horizontal" method="POST" enctype="multipart/form-data">
		
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="name" name="name" placeholder="Name *" value="<?=@$_POST['name']?>">
			</div>
		  </div>
		  
		  
		  <div class="form-group">
			<div>
			  <input type="email" class="form-control" id="email" name="email" placeholder="Email *" value="<?=@$_POST['email']?>">
			</div>
		  </div>
		  
		  
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="mobile" name="mobile" placeholder="Mobile *" value="<?=@$_POST['mobile']?>">
			</div>
		  </div>
		
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="country" name="country" placeholder="Country" value="<?=@$_POST['country']?>">
			</div>
		  </div>
		
		  <div class="form-group">
			<div>
			  <input type="text" class="form-control" id="city" name="city" placeholder="City" value="<?=@$_POST['city']?>">
			</div>
		  </div>
				  
		<div class="form-group">
			<div>
			  <input type="text" class="form-control" id="street" name="street" placeholder="Street" value="<?=@$_POST['street']?>">
			</div>
		  </div>
		  
		<div class="form-group">
			<div>
			  <input type="file" id="img" name="img" placeholder="Upload image">
			</div>
		</div>
		  
		  <div class="form-group">
			<div>
			  <button type="submit" class="btn btn-primary" name="add">Add</button>
			  <button type="reset" class="btn btn-warning">Reset</button>
			</div>
		  </div>
		  
		</form>
	</body>
</html>