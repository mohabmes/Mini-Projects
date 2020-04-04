<?php

include("inc/auth.class.php");
include("inc/virtualtrader.class.php");
include("inc/simple_html_dom.php");
session_start();

$auth = new Auth;
$virtualtrader = new VirtualTrader;
//$res = $virtualtrader->UpdateStockDB();



if(isset($_COOKIE['auth_session']))
{
	if($auth->checksession($_COOKIE['auth_session']))
	{
		$session = $auth->sessioninfo($_COOKIE['auth_session']);
		$userbalance = $virtualtrader->GetUserBalance($session['username']);
	}
}

function set_alert_msg($msg, $type='error'){
	$_SESSION['alert_msg'] = $msg;
	$_SESSION['alert_msg_type']=$type;
}

function redirect_to($to){
	header("Location: ?page={$to}");
	exit();
}

function check_if_loggedin(){
	if(!isset($_COOKIE['auth_session']) || empty($_COOKIE['auth_session']))
	{
			set_alert_msg('Please, Login first!!');
			redirect_to('login');
	}
}



if(!empty($_GET['page']))
{
	$page = $_GET['page'];

	if($page == 'home')
		include("pages/home.php");
	elseif ($page == 'login')
		include("pages/login.php");
	elseif ($page == 'register')
		include("pages/register.php");
	elseif ($page == 'logout')
		include("pages/logout.php");
	elseif ($page == 'stocks')
		include("pages/stocks.php");
	elseif ($page == 'stockinfo')
		include("pages/stockinfo.php");
	elseif ($page == 'mystocks')
		include("pages/mystocks.php");
	elseif ($page == 'money')
		include("pages/money.php");
	else
		include("pages/404.php");
}
else
{
	header("Location: ?page=home");
	exit();
}

?>
