<html>
<head>
	<title>Messenger</title>
  <link  rel="stylesheet" type="text/css" href="<?php echo RES.'style/global.css'; ?>">
  <base href="//localhost/Messenger/" />
</head>
<body onload="checkcookie(); update();">
  <div id="whitebg"></div>
  <div id="loginbox">
    <h1>Pick a username:</h1>
    <p>
      <input type="text" name="pickusername" id="cusername" placeholder="Pick a username" class="msginput">
    </p>
    <p class="buttonp">
      <button onclick="chooseusername()">Choose Username</button>
    </p>
  </div>
  <div class="msg-container">
  	<div class="header">Messenger</div>
  	<div class="msg-area" id="msg-area"></div>
  	<div class="bottom">
      <input type="text" name="msginput" class="msginput" id="msginput" onkeydown="if (event.keyCode == 13) sendmsg()" value="" placeholder="Press enter to send message">
    </div>
  </div>
</body>
<script src="<?php echo RES . "script/script.js"; ?>"></script>
</html>
