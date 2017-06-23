<?php
session_start();
include('app/shortener.php');

$s = new Shortener();

if(isset($_POST['url'])){
  $url = $_POST['url'];

  if($code = $s->makeCode($url)){
    $_SESSION['feedback'] = "Generated! Your URL is :  <a target='_blank' href=\"./$code\">http:/localhost/url/$code</a>";
  }
  else{
    $_SESSION['feedback'] = "There was a problem, Invalid URL, perhaps?";
  }

}
header('Location: index.php');
?>
