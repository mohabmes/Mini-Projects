<?php
require('inc/connection.php');
require('inc/function.php');

//header title
$header = "Play | Homepage";

//Get number of Videos to create pagination
$numVideos = getAllVideosCount();
//$numPages = $numVideos/8;

$start_item=0;
$item_on_page=8;
$end_item=$start_item+$item_on_page;
$pages = intval($numVideos/$item_on_page);
$pages += ($numVideos%$item_on_page>0);


if(!empty($_GET['p'])&& isset($_GET['p']) && is_numeric($_GET['p'])){
	if($_GET['p']>$pages){
		header('Location: index.php');
		die();
	}
	$p = intval($_GET['p']);
	$start_item = ($p-1)*$item_on_page;
}
//Get 4 random videos
$randomVideos = get4RandomVideos();

//Get Recently Added Videos
$videos = getRecentVideos($start_item, $item_on_page);

require('inc/header.php');

?>
	
<?php 
	if(!isset($_GET['p'])){ 
		echo '<p class="title">Random Videos</p>';
		echo '<div class="panel">';
		foreach($randomVideos as $k => $i){
			videoPreview($i);
		}
		echo '</div>';
	}
?>

<p class="title">Added Recently</p>
<div class="panel wrapper">		
	<?php
		if(empty($videos)){
			echo '<center><< No Videos Uploaded >></center>';
		}else{
			foreach($videos as $k => $i){
				videoPreview($i);
			}
		}
	?>
</div>
<div class="content">
	<?php
		for($i=1; $i<=$pages; $i++){
			if($i==1){echo '<a href="index.php">'.$i.'</a>';}
			else echo '<a href="index.php?p='.$i.'">'.$i.'</a>';
			if($i<$pages){echo '<span class="separate"> | </span>';}
		}
	?>
</div>
<?php require('inc/footer.php');?>