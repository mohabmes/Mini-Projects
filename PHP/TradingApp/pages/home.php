<?php
$title = "TradingApp - Home";
include('header.php');

check_if_loggedin();
?>

<div class="logo"></div>

<div class="mx-auto" style="width:450px;">
<center>
	<h1>Welcome</h1>
	<p>You are logged in as <?php echo $session['username']; ?></p>
	<br/><br/>

	<br/>
	<br/>
	<table>

			<tr>
				<td>&gt; <a href="?page=stocks">Stock List</a></td>
			</tr>
			<tr>
				<td>&gt; <a href="?page=mystocks">My Stocks</a></td>
			</tr>
			<tr>
				<td>&gt; <a href="?page=money&op=withdraw">Withdrawing Money</a></td>
			</tr>
			<tr>
				<td>&gt; <a href="?page=money&op=deposit">Depositing Money</a></td>
			</tr>
			<tr>
				<td>&gt; <a href="?page=logout">Logout</a></td>
			</tr>
	</table>
</center>

</div>
</div>
</body>
</html>
