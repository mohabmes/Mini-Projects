<?php
if(!empty($_COOKIE['auth_session']))
{
	$auth->deletesession($_COOKIE['auth_session']);
	set_alert_msg('See you Soon, Bye.');
	redirect_to('login');
}

redirect_to('login');
?>
