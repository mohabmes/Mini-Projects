<?php
$title = "TradingApp - Stock";
include('header.php');

check_if_loggedin();

if(!empty($_GET['code']))
	$stockcode = $_GET['code'];
else
	redirect_to('stocks');

if(!$virtualtrader->CheckStock($stockcode)){
	set_alert_msg('Stock code is invalid');
	redirect_to('stocks');
}

if(empty($virtualtrader->errormsg))
	$stockinfo = $virtualtrader->GetStockInfoDB($stockcode);

if(isset($_POST['action']))
{
	if($_POST['action'] == '1')
	{
		$quantity = (int) $_POST['quantity'];
		$log = $virtualtrader->BuyShare($stockcode, $quantity, $session['username']);
		if (!$log)
			set_alert_msg('Check the values, something went wrong!!', 'info');
	}
	elseif($_POST['action'] == '2')
	{
		$quantity = (int) $_POST['quantity'];
		$log = $virtualtrader->SellShare($stockcode, $quantity, $session['username']);
		if (!$log)
			set_alert_msg('Check the values, something went wrong!!', 'info');
	}
}

?>


<div class=" mx-auto" style="width:450px;">
<?php if(isset($stockinfo)):?>
		<?php
		if($stockinfo['diff'] > 0)
			$arrow_img = "<img src=\"img/up.png\"/> ";
		elseif($stockinfo['diff'] < 0)
			$arrow_img = "<img src=\"img/down.png\"/> ";
		else
			$arrow_img = "<img src=\"img/equal.png\"/> ";
		?>
		<br>
		<table>
			<tr>
				<td>Company Name : </td>
				<td><strong><?php echo $stockinfo['name']; ?></strong></td>
			</tr>
			<tr>
				<td>Share Price : </td>
				<td><strong><?php echo $stockinfo['price']; ?>  $</strong></td>
			</tr>
			<tr>
				<td>Price Difference : </td>
				<td><strong>
					<?=$arrow_img?><?=abs($stockinfo['diff'])?>
					(<?php if($stockinfo['diff_perc'] > 0) { echo "+"; } echo $stockinfo['diff_perc']; ?> %)</strong>
				</td>
			</tr>
			<tr>
				<td>Shares : </td>
				<td>
					<?php if($quantity = $virtualtrader->ShareQty($session['username'], $stockinfo['code'])): $total = $quantity * $stockinfo['price'];?>
				    (<strong><?=$quantity?></strong>) share(s), currently worth <strong><?=$total?> $</strong>
					<?php else: ?>
				    <strong>0</strong> share
					<?php endif; ?>
				</td>
			</tr>
		</table><br>
    <form method="post" action="?page=stockinfo&code=<?php echo $stockinfo['code']; ?>">
		<label for="male">Buy : </label>
    <input name="action" type="hidden" value="1">
    <input name="quantity" type="text" maxlength="5" placeholder="Quantity">
    <input type="submit" value="Buy">
    </form><br/>
    <form method="post" action="?page=stockinfo&code=<?php echo $stockinfo['code']; ?>">
		<label for="male">Sell : </label>
    <input name="action" type="hidden" value="2">
    <input name="quantity" type="text" maxlength="5" placeholder="Quantity">
    <input type="submit" value="Sell">
    </form><br/>
<?php endif ?>
</div>
</div>
</body>
</html>
