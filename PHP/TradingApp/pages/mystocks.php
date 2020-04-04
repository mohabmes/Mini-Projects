<?php
$title = "TradingApp - Your Stocks";
include('header.php');

check_if_loggedin();
?>

<div class="content">
<center>
<h1>My Stocks</h1>

<?php if($data = $virtualtrader->GetUserStocks($session['username'])): ?>
	<table width="100%" border="0" cellspacing="3" cellpadding="3">
	<tr>
		<td height="50"><b>Stock Name :</b></td>
		<td><b>Stock Code :</b></td>
		<td><b>Previous Price :</b></td>
		<td><b>Current Price :</b></td>
		<td><b>Difference :</b></td>
		<td></td>
	</tr>
	<?php foreach($data as $table) : ?>
	<tr>
		<td><?php echo $table['name']; ?></td>
		<td><?php echo $table['code']; ?></td>
		<td><?php echo $table['p_price']; ?> $</td>
		<td><?php echo $table['c_price']; ?> $</td>
		<td><?php if($table['diff'] > 0) { echo "<img src=\"img/up.png\"/> "; } elseif($table['diff'] < 0) { echo "<img src=\"img/down.png\"/> "; } else { echo "<img src=\"img/equal.png\"/> "; } echo abs($table['diff']); ?></td>
		<td><a href="?page=stockinfo&code=<?php echo $table['code']; ?>"><img src="img/info.png" /></a></td>
	</tr>
	<?php endforeach ?>
</table>
<?php  else:?>
0 stocks in database !
<?php endif; ?>
</center>
</div>
</div>
</body>
</html>
