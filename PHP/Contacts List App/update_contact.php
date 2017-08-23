<?php
require_once('inc/db.php');
$header = "Update";

require_once('inc/header.php');

if(!isset($_SESSION['user_id'])){
	header('Location: index.php');
	die();
}

//	//	//	//	//	//	//
$contact = new Contact();
$result = $contact->getContact($_GET['id'], $_SESSION['user_id']);
//	//	//	//	//	//	//

if(empty($result) || $result['user_id']!=$_SESSION['user_id']){
	header('Location: index.php?error=Contact doesn\'t exist');
	die();
}

$file = "./img/".$result['id'].".jpg";
if(is_file($file)){
	$pimgsrc = "./img/".$result['id'].".jpg";
} else {
	$pimgsrc = "img/avatar.jpg";
}

if(isset($_POST['update'])){
	if(!empty($_POST['name']) && !empty($_POST['email']) &&
		!empty($_POST['mobile'])){

		//	//	//	//	//	//	//		
		$data = [
			'name' => $_POST['name'],
			'email' => $_POST['email'],
			'mobile' => $_POST['mobile'],
			'country' => $_POST['country'],
			'city' => $_POST['city'],
			'street' => $_POST['street']
		];
		
		$update = $contact->updateContact($_GET['id'], $data);
		//	//	//	//	//	//	//

		if($update){
			header('Location: index.php?msg=Updated Successfully');
			die();
		} else {
			header('Location: index.php?error=Something Went wrong');
			die();
		}

	} else {
		header("Location: $_SERVER[REQUEST_URI]&error=Some fields required");
		die();
	}
}

?>
<div class="container">
	
	<div class="container col-md-8 col-md-offset-2 well custm-bx">
	<div class="bx">
		<h3 class="col-md-offset-5">Update Contact</h3>
	</div>
	
	<div class="col-md-3 profile">
		<img src='<?=$pimgsrc?>'>
	</div>

	<div class="col-md-9">
		<form class="form-horizontal" method="POST">
			
			  <div class="form-group">
				<div>
				  <input type="text" class="form-control" id="name" name="name" placeholder="Name *" value="<?=@$result['name']?>">
				</div>
			  </div>
			  
			  
			  <div class="form-group">
				<div>
				  <input type="email" class="form-control" id="email" name="email" placeholder="Email *" value="<?=@$result['email']?>">
				</div>
			  </div>
			  
			  
			  <div class="form-group">
				<div>
				  <input type="text" class="form-control" id="mobile" name="mobile" placeholder="Mobile *" value="<?=@$result['mobile']?>">
				</div>
			  </div>
			
			  <div class="form-group">
				<div>
				  <input type="text" class="form-control" id="country" name="country" placeholder="Country" value="<?=@$result['country']?>">
				</div>
			  </div>
			
			  <div class="form-group">
				<div>
				  <input type="text" class="form-control" id="city" name="city" placeholder="City" value="<?=@$result['city']?>">
				</div>
			  </div>
					  
			<div class="form-group">
				<div>
				  <input type="text" class="form-control" id="street" name="street" placeholder="Street" value="<?=@$result['street']?>">
				</div>
			  </div>

			  
			  <div class="form-group">
				<div>
				  <button type="submit" class="btn btn-primary" name="update">Update</button>
				</div>
			  </div>
			  
			</form>
		</div>
	</body>
</html>