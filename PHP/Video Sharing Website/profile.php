<?php
require('inc/connection.php');
require('inc/function.php');

if(!isset($_GET['username'])|| empty($_GET['username'])|| is_numeric($_GET['username']) ){
	header('Location: index.php');
}
$username = $_GET['username'];

//Check if profile username exist
$userData = getUserData($username);
//if the query result is empty or not set redirect
if(!isset($userData)||empty($userData)){
	header('Location: index.php');
}
$id = $userData['id'];



/*
//Get number of Videos to create pagination
$numVideos = getNumOfVideos($id);

if(!empty($_GET['p'])&& isset($_GET['p']) && is_numeric($_GET['p'])){
	if($_GET['p']>$pages){
		header('Location: profile.php?username='.$username);
		die();
	}
	$p = intval($_GET['p']);
	$start_item = ($p-1)*$item_on_page;
	$item_on_page-=$p*8;
}else{
	$start_item=0;
	if($numVideos<8){
		$item_on_page=$numVideos;
	}else{
		$item_on_page=8;
	}
}
$pages = intval($numVideos/8);
$pages += ($numVideos%$item_on_page>0);
*/

//if $error_message is empty && is not setted
if(empty($error_message)&& !isset($error_message)){
	$videos = getUserVideo($id);
	$fullname = ucfirst($userData['fullname']);
	$header = "Profile | ".$fullname;
	require('inc/header.php');
}
?>

<p class="title"><?php echo '<a href="profile.php?username='.$username.'">'.$fullname.'</a> (@'.$username.')';?></p>
	<div class="panel">
		<?php
			if(empty($videos)){
				echo '<br><br><br><br><br><center><< No Video Uploaded Yet >></center>';
			}else{
				foreach($videos as $k=>$i){
					//$videos as $k => $i)
					videoPreview($i);
				}
			}
		?>
	</div>
<!--div class="content">
	<?php /*
		for($i=1; $i<=$pages; $i++){
			echo '<a href="profile.php?username='.$username.'&p='.$i.'">'.$i.'</a>';
			if($i<$pages){echo '<span class="separate"> | </span>';}
		}*/
	?>
</div-->
<?php require('inc/footer.php');?>