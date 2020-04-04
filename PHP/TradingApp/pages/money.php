<?php
$title = "TradingApp - Home";
include('header.php');

check_if_loggedin();

if($_GET['op'])
  $type = $_GET['op'];


if($_POST){
  $amount = $_POST['amount'];
  if($type == 'deposit'){
    $userbalance += $amount;
    $virtualtrader->UpdateBalance($session['username'], $userbalance);
    redirect_to('home');
  }
  elseif($type == 'withdraw'){
    $userbalance -= $amount;
    $virtualtrader->UpdateBalance($session['username'], $userbalance);
    redirect_to('home');
  }
}

?>

<div class="container mx-auto" style="width:450px;">
<?php if($type == 'deposit'):?>
<center>Deposit Money</center>
<?php else:?>
<center>Withdraw Money</center>
<?php endif;?>
<br><br><br>
<form method="post" action="?page=money&op=<?=$type?>">
<table class="center" border="0" cellspacing="5" cellpadding="5">
  <tr>
    <td>Credit Card Nomber :</td>
    <td><label for="username"></label>
    <input type="text" disabled value="XXXXXXXXXXXXXXXXXXX" /></td>
  </tr>
  <tr>
    <td>Password :</td>
    <td><label for="password"></label>
    <input name="text" disabled value="XXXXXXXXXXXXXXXXXXX" /></td>
  </tr>
  <tr>
    <td>Amount :</td>
    <td><label for="amount"></label>
    <input name="amount" type="text" id="amount" maxlength="30" /></td>
  </tr>

  <tr>
		<td></td>
    <td><br /><input type="submit" value="OK" /></td>
  </tr>
  <tr>
    <td></td>
    <td><br><br><h6 style="color:red">** Just for demo purposes.</h6></td>
  </tr>
</table>
</form>
</div>
</div>
</body>
</html>
