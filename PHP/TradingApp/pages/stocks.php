<?php
$title = "TradingApp - Register";
include('header.php');

check_if_loggedin(1);

?>
<div class="content">
<h1><center>Stock List</center></h1>
<?php if($data = $virtualtrader->GetStocks()):?>
	<table width="100%" border="0" cellspacing="3" cellpadding="3">
	<tr>
		<td height="50"><b>Stock Name :</b></td>
		<td><b>Stock Code :</b></td>
		<td><b>Price :</b></td>
		<td><b>Difference :</b></td>
		<td></td>
	</tr>
		<?php foreach($data as $table):?>
		<tr>
			<td><?php echo $table['name']; ?></td>
			<td><?php echo $table['code']; ?></td>
			<td><?php echo $table['price']; ?> $</td>
			<td><?php if($table['diff'] > 0) { echo "<img src=\"img/up.png\"/> "; } elseif($table['diff'] < 0) { echo "<img src=\"img/down.png\"/> "; } else { echo "<img src=\"img/equal.png\"/> "; } echo abs($table['diff']); ?> (<?php if($table['diff_perc'] > 0) { echo "+"; } echo $table['diff_perc']; ?> %)</td>
			<td><a href="?page=stockinfo&code=<?php echo $table['code']; ?>"><img src="img/info.png" /></a></td>
		</tr>
		<?php endforeach; ?>
	</table>
<?php  else: ?>
<h1><center>0 stocks in database !</center></h1>
0 stocks in database !
<?php endif; ?>
</div>
</div>
</body>
</html>
