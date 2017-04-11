<?php
require('inc/connection.php');
require('inc/function.php');

if(!isset($_GET['id'])|| empty($_GET['id'])|| !is_numeric($_GET['id']) ){
	header('Location: index.php');
}

$id = $_GET['id'];

//Check if video id exist first
$video = getVideoData($id);

if($_SERVER["REQUEST_METHOD"] != "POST"){
	//if the query result is empty or not setted redirect
	if(!isset($video)||empty($video)){
		header('Location: index.php');
	}
}


//if $error_message is empty && is not setted
if(empty($error_message)&& !isset($error_message)){
	
	//retrieve the uploader data
	$uploader = getUploaderData($id);

	$fullname = ucfirst($uploader['fullname']);
	$username = $uploader['username'];
	$title = ucfirst($video['title']);
	$description = $video['description'];
	$loca = $video['vid_loca'];
	$date = $video['date'];

}

$header = "Video | ".$title;
require('inc/header.php');

$comments = getAllComment($id);


if($_SERVER["REQUEST_METHOD"] == "POST"){
	loader("Wait a Sec");
	if(isset($_POST['comment'])){
		//Filtering input
		$comment = trim(filter_input(INPUT_POST,"comment",FILTER_SANITIZE_SPECIAL_CHARS));
		//date of the video
		$t=time();
		$date=date("M d, Y",$t);
		addComment($comment, $id, $_SESSION['id'], $date);

	}
	if(isset($_POST['Cdel'])){
		deleteComment($_POST['id']);
	}
	if(isset($_POST['Vdel'])){
		echo "Deleting ... ";
		deleteVideo($_POST['id']);
		deleteAllCommentOfVideo($id);
		//delete Video & Thumbnail src
		deleteThumbnail_video($loca);
	}
	header('refresh:3;url=video.php?id='.$id.'&op=done');
}

?>
<div class="video">
	<video controls name="media" poster="/Play/media/thumbnail/<?php echo $loca;?>.jpg">
		<source src="/Play/media/video/<?php echo $loca;?>.mp4" type="video/mp4">
			Media Player Error.
	</video>
	<h3><?php 
			echo $title; 
			if(@$_SESSION['id']==$uploader['vid'] || @checkAdmin()){
			echo'
			<form method="POST" class="btn-dlt">
				<input type="text" name="id" value="'.$id.'" style="display:none;">
				<input type="submit" value="Delete This Video" name="Vdel">
			</form>
			';
		}
		?>
	</h3>
	<span>
		Uploaded By 
		<a href="profile.php?username=<?php echo $username; ?>"><b><?php echo $fullname; ?></b></a>
		in
		<b><?php echo $date; ?></b>
	</span>
</div>


<div class="video">
	<b>Description</b>
	<p>
	<?php echo $description; ?>
	</p>
</div>

<div class="video">
	<b>Comments</b>
	<?php
		if(!loggedin()){ echo "<center><h6>Please Login to comment</h6></center>";}
		if(empty($comments)){
			echo '<center><< No Comments to show >></center>';
		}else{
			foreach($comments as $k => $i){
				echo '
					<div class="comment">		
						<b><a href="profile.php?username='.$i['username'].'">'.$i['fullname'].'</a></b> @'.$i['username'].'<span class="separate"> | </span><i>'.$i['date'].'</i>';
						if(@$_SESSION['id']==$uploader['vid'] || @checkAdmin()){
						echo'
						<form method="POST" class="btn-dlt">
							<input type="text" name="id" value="'.$i['id'].'" style="display:none;">
							<input type="submit" class="btn-dlt" value="Delete This Comment" name="Cdel">
						</form>
						';
					}
				echo '<p>'.$i['content'].'</p>
				</div>';
			}
		}
	?>
</div>

<div class="video" style="<?php if(!loggedin()||checkAdmin()){ echo "display:none;";}?>">
	<b>Write Your Comment</b>
	<form action="" method="POST">
		<textarea name="comment" cols="122" rows="5"></textarea>
		<input type="submit" value="comment">
	</form>
</div>
<?php require('inc/footer.php');?>