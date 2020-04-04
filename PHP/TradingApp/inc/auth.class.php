<?php
$loc = 'en';
class auth
{
	public $mysqli;
	public $errormsg;
	public $successmsg;

	function __construct()
	{
		include("config.php");

		$this->mysqli = new mysqli($db['host'], $db['user'], $db['pass'], $db['name']);
	}

	/*
	* Log user in via MySQL Database
	* @param string $username
	* @param string $password
	* @return boolean
	*/

	function login($username, $password)
	{
		include("config.php");
		include("lang.php");

				// Input verification :
				if(empty($username) || strlen($username) == 0) { return $lang[$loc]['auth']['login_username_empty']; }
				elseif(strlen($username) > 30) { return $lang[$loc]['auth']['login_username_long'];}
				elseif(strlen($username) < 3) { return $lang[$loc]['auth']['login_username_short']; }
				elseif(strlen($password) == 0) { return  $lang[$loc]['auth']['login_password_empty']; }
				elseif(strlen($password) > 30) { return  $lang[$loc]['auth']['login_password_short']; }
				elseif(strlen($password) < 5) { return $lang[$loc]['auth']['login_password_long']; }
				else
				{
					// Input is valid

					$password = $this->hashpass($password);

					$query = $this->mysqli->prepare("SELECT isactive FROM users WHERE username = ? AND password = ?");
					$query->bind_param("ss", $username, $password);
					$query->bind_result($isactive);
					$query->execute();
					$query->store_result();
					$count = $query->num_rows;
					$query->fetch();
					$query->close();

					if($count == 0)
					{
						// Username and / or password are incorrect

						return $lang[$loc]['auth']['login_incorrect'];
					}
					else
					{

							$this->newsession($username);

							$this->LogActivity($username, "AUTH_LOGIN_SUCCESS", "User logged in");

							$this->successmsg[] = $lang[$loc]['auth']['login_success'];

							return true;

					}
				}
	}

	/*
	* Register a new user into the database
	* @param string $username
	* @param string $password
	* @param string $verifypassword
	* @param string $email
	* @return boolean
	*/

	function register($username, $password, $verifypassword, $email)
	{
		include("config.php");
		include("lang.php");


			// Input Verification :

			if(strlen($username) == 0) { return $lang[$loc]['auth']['register_username_empty']; }
			elseif(strlen($username) > 30) { return $lang[$loc]['auth']['register_username_long']; }
			elseif(strlen($username) < 3) { return $lang[$loc]['auth']['register_username_short']; }
			if(strlen($password) == 0) { return $lang[$loc]['auth']['register_password_empty']; }
			elseif(strlen($password) > 30) { return $lang[$loc]['auth']['register_password_long']; }
			elseif(strlen($password) < 5) { return $lang[$loc]['auth']['register_password_short']; }
			elseif($password !== $verifypassword) { return $lang[$loc]['auth']['register_password_nomatch']; }
			elseif(strstr($password, $username)) { return $lang[$loc]['auth']['register_password_username']; }
			if(strlen($email) == 0) { return $lang[$loc]['auth']['register_email_empty']; }
			elseif(strlen($email) > 100) { return $lang[$loc]['auth']['register_email_long']; }
			elseif(strlen($email) < 5) { return $lang[$loc]['auth']['register_email_short']; }
			elseif(!filter_var($email, FILTER_VALIDATE_EMAIL)) { return $lang[$loc]['auth']['register_email_invalid']; }

			if(@count($this->errormsg) == 0)
			{
				// Input is valid

				$query = $this->mysqli->prepare("SELECT * FROM users WHERE username=?");
				$query->bind_param("s", $username);
				$query->execute();
				$query->store_result();
				$count = $query->num_rows;
				$query->close();

				if($count != 0)
				{
					// Username already exists

					$this->LogActivity("UNKNOWN", "AUTH_REGISTER_FAIL", "Username ({$username}) already exists");

					return $lang[$loc]['auth']['register_username_exist'];

				}
				else
				{
					// Username is not taken

					$query = $this->mysqli->prepare("SELECT * FROM users WHERE email=?");
					$query->bind_param("s", $email);
					$query->execute();
					$query->store_result();
					$count = $query->num_rows;
					$query->close();

					if($count != 0)
					{
						// Email address is already used

						$this->LogActivity("UNKNOWN", "AUTH_REGISTER_FAIL", "Email ({$email}) already exists");

						return $lang[$loc]['auth']['register_email_exist'];

					}
					else
					{
						// Email address isn't already used

						$password = $this->hashpass($password);
						$activekey = $this->randomkey(15);

						$query = $this->mysqli->prepare("INSERT INTO users (username, password, email, activekey, isactive) VALUES (?, ?, ?, ?, 1)");
						$query->bind_param("ssss", $username, $password, $email, $activekey);
						$query->execute();
						$query->close();

						// $message_from = $auth_conf['email_from'];
						// $message_subj = $auth_conf['site_name'] . " - Account activation required !";
						// $message_cont = "Hello {$username}<br/><br/>";
						// $message_cont .= "You recently registered a new account on " . $auth_conf['site_name'] . "<br/>";
						// $message_cont .= "To activate your account please click the following link<br/><br/>";
						// $message_cont .= "<b><a href=\"" . $auth_conf['base_url'] . "?page=activate&username={$username}&key={$activekey}\">Activate my account</a></b>";
						// $message_head = "From: {$message_from}" . "\r\n";
						// $message_head .= "MIME-Version: 1.0" . "\r\n";
						// $message_head .= "Content-type: text/html; charset=iso-8859-1" . "\r\n";
						//
						// mail($email, $message_subj, $message_cont, $message_head);

						$this->LogActivity($username, "AUTH_REGISTER_SUCCESS", "Account created and activation email sent");

						return $lang['en']['auth']['register_success'];
					}
				}
			}


	}

	/*
	* Creates a new session for the provided username and sets cookie
	* @param string $username
	*/

	function newsession($username)
	{
		include("config.php");

		$hash = md5(microtime());

		// Fetch User ID :

		$query = $this->mysqli->prepare("SELECT id FROM users WHERE username=?");
		$query->bind_param("s", $username);
		$query->bind_result($uid);
		$query->execute();
		$query->fetch();
		$query->close();

		// Delete all previous sessions :

		$query = $this->mysqli->prepare("DELETE FROM sessions WHERE username=?");
		$query->bind_param("s", $username);
		$query->execute();
		$query->close();

		$ip = $_SERVER['REMOTE_ADDR'];
		$expiredate = date("Y-m-d H:i:s", strtotime($auth_conf['session_duration']));
		$expiretime = strtotime($expiredate);

		$query = $this->mysqli->prepare("INSERT INTO sessions (uid, username, hash, expiredate, ip) VALUES (?, ?, ?, ?, ?)");
		$query->bind_param("issss", $uid, $username, $hash, $expiredate, $ip);
		$query->execute();
		$query->close();

		setcookie("auth_session", $hash, $expiretime);
	}

	/*
	* Deletes the user's session based on hash
	* @param string $hash
	*/

	function deletesession($hash)
	{
		include("config.php");
		include("lang.php");

		$query = $this->mysqli->prepare("SELECT username FROM sessions WHERE hash=?");
		$query->bind_param("s", $hash);
		$query->bind_result($username);
		$query->execute();
		$query->store_result();
		$count = $query->num_rows;
		$query->fetch();
		$query->close();

		if($count == 0)
		{
			// Hash doesn't exist

			$this->LogActivity("UNKNOWN", "AUTH_LOGOUT", "User session cookie deleted - Database session not deleted - Hash ({$hash}) didn't exist");

			$this->errormsg[] = $lang[$loc]['auth']['deletesession_invalid'];

			setcookie("auth_session", $hash, time() - 3600);
		}
		else
		{
			// Hash exists, Delete all sessions for that username :

			$query = $this->mysqli->prepare("DELETE FROM sessions WHERE username=?");
			$query->bind_param("s", $username);
			$query->execute();
			$query->close();

			$this->LogActivity($username, "AUTH_LOGOUT", "User session cookie deleted - Database session deleted - Hash ({$hash})");

			setcookie("auth_session", $hash, time() - 3600);
		}
	}

	/*
	* Provides an associative array of user info based on session hash
	* @param string $hash
	* @return array $session
	*/

	function sessioninfo($hash)
	{
		include("config.php");
		include("lang.php");

		$query = $this->mysqli->prepare("SELECT uid, username, expiredate, ip FROM sessions WHERE hash=?");
		$query->bind_param("s", $hash);
		$query->bind_result($session['uid'], $session['username'], $session['expiredate'], $session['ip']);
		$query->execute();
		$query->store_result();
		$count = $query->num_rows;
		$query->fetch();
		$query->close();

		if($count == 0)
		{
			// Hash doesn't exist

			$this->errormsg[] = $lang[$loc]['auth']['sessioninfo_invalid'];

			setcookie("auth_session", $hash, time() - 3600);

			return false;
		}
		else
		{
			// Hash exists

			return $session;
		}
	}

	/*
	* Checks if session is valid (Current IP = Stored IP + Current date < expire date)
	* @param string $hash
	* @return bool
	*/

	function checksession($hash)
	{
		$query = $this->mysqli->prepare("SELECT username, expiredate, ip FROM sessions WHERE hash=?");
		$query->bind_param("s", $hash);
		$query->bind_result($username, $db_expiredate, $db_ip);
		$query->execute();
		$query->store_result();
		$count = $query->num_rows;
		$query->fetch();
		$query->close();

		if($count == 0)
		{
			// Hash doesn't exist

			setcookie("auth_session", $hash, time() - 3600);

			$this->LogActivity($username, "AUTH_CHECKSESSION", "User session cookie deleted - Hash ({$hash}) didn't exist");

			return false;
		}
		else
		{
			if($_SERVER['REMOTE_ADDR'] != $db_ip)
			{
				// Hash exists, but IP has changed

				$query = $this->mysqli->prepare("DELETE FROM sessions WHERE username=?");
				$query->bind_param("s", $username);
				$query->execute();
				$query->close();

				setcookie("auth_session", $hash, time() - 3600);

				$this->LogActivity($username, "AUTH_CHECKSESSION", "User session cookie deleted - IP Different ( DB : {$db_ip} / Current : " . $_SERVER['REMOTE_ADDR'] . " )");

				return false;
			}
			else
			{
				$expiredate = strtotime($db_expiredate);
				$currentdate = strtotime(date("Y-m-d H:i:s"));

				if($currentdate > $expiredate)
				{
					// Hash exists, IP is the same, but session has expired

					$query = $this->mysqli->prepare("DELETE FROM sessions WHERE username=?");
					$query->bind_param("s", $username);
					$query->execute();
					$query->close();

					setcookie("auth_session", $hash, time() - 3600);

					$this->LogActivity($username, "AUTH_CHECKSESSION", "User session cookie deleted - Session expired ( Expire date : {$db_expiredate} )");

					return false;
				}
				else
				{
					// Hash exists, IP is the same, date < expiry date

					return true;
				}
			}
		}
	}

	/*
	* Returns a random string, length can be modified
	* @param int $length
	* @return string $key
	*/

	function randomkey($length = 10)
	{
		$chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
		$key = "";

		for($i = 0; $i < $length; $i++)
		{
			$key .= $chars{rand(0, strlen($chars) - 1)};
		}

		return $key;
	}

	/*
	* Adds a new attempt to database based on user's IP
	* @param string $ip
	*/

	function addattempt($ip)
	{
		include("config.php");

		$query = $this->mysqli->prepare("SELECT count FROM attempts WHERE ip = ?");
		$query->bind_param("s", $ip);
		$query->bind_result($attempt_count);
		$query->execute();
		$query->store_result();
		$count = $query->num_rows;
		$query->fetch();
		$query->close();

		if($count == 0)
		{
			// No record of this IP in attempts table already exists, create new

			$attempt_expiredate = date("Y-m-d H:i:s", strtotime($auth_conf['security_duration']));
			$attempt_count = 1;

			$query = $this->mysqli->prepare("INSERT INTO attempts (ip, count, expiredate) VALUES (?, ?, ?)");
			$query->bind_param("sis", $ip, $attempt_count, $attempt_expiredate);
			$query->execute();
			$query->close();
		}
		else
		{
			// IP Already exists in attempts table, add 1 to current count

			$attempt_expiredate = date("Y-m-d H:i:s", strtotime($auth_conf['security_duration']));
			$attempt_count = $attempt_count + 1;

			$query = $this->mysqli->prepare("UPDATE attempts SET count=?, expiredate=? WHERE ip=?");
			$query->bind_param("iss", $attempt_count, $attempt_expiredate, $ip);
			$query->execute();
			$query->close();
		}
	}

	/*
	* Provides amount of attempts already in database based on user's IP
	* @param string $ip
	* @return int $attempt_count
	*/

	function getattempt($ip)
	{
		$query = $this->mysqli->prepare("SELECT count FROM attempts WHERE ip = ?");
		$query->bind_param("s", $ip);
		$query->bind_result($attempt_count);
		$query->execute();
		$query->store_result();
		$count = $query->num_rows;
		$query->fetch();
		$query->close();

		if($count == 0)
		{
			$attempt_count = 0;
		}

		return $attempt_count;
	}

	/*
	* Function used to remove expired attempt logs from database (Recommended as Cron Job)
	*/

	function expireattempt()
	{
		$query = $this->mysqli->prepare("SELECT ip, expiredate FROM attempts");
		$query->bind_result($ip, $expiredate);
		$query->execute();
		$query->store_result();
		$count = $query->num_rows;

		$curr_time = strtotime(date("Y-m-d H:i:s"));

		if($count != 0)
		{
			while($query->fetch())
			{
				$attempt_expiredate = strtotime($expiredate);

				if($attempt_expiredate <= $curr_time)
				{
					$query2 = $this->mysqli->prepare("DELETE FROM attempts WHERE ip = ?");
					$query2->bind_param("s", $ip);
					$query2->execute();
					$query2->close();
				}
			}
		}
	}

	/*
	* Logs users actions on the site to database for future viewing
	* @param string $username
	* @param string $action
	* @param string $additionalinfo
	* @return boolean
	*/

	function LogActivity($username, $action, $additionalinfo = "none")
	{
		include("config.php");
		include("lang.php");

		if(strlen($username) == 0) { $username = "GUEST"; }
		elseif(strlen($username) < 3) { $this->errormsg[] = $lang[$loc]['auth']['logactivity_username_short']; return false; }
		elseif(strlen($username) > 30) { $this->errormsg[] = $lang[$loc]['auth']['logactivity_username_long']; return false; }

		if(strlen($action) == 0) { $this->errormsg[] = $lang[$loc]['auth']['logactivity_action_empty']; return false; }
		elseif(strlen($action) < 3) { $this->errormsg[] = $lang[$loc]['auth']['logactivity_action_short']; return false; }
		elseif(strlen($action) > 100) { $this->errormsg[] = $lang[$loc]['auth']['logactivity_action_long']; return false; }

		if(strlen($additionalinfo) == 0) { $additionalinfo = "none"; }
		elseif(strlen($additionalinfo) > 500) { $this->errormsg[] = $lang[$loc]['auth']['logactivity_addinfo_long']; return false; }

		if(@count($this->errormsg) == 0)
		{
			$ip = $_SERVER['REMOTE_ADDR'];
			$date = date("Y-m-d H:i:s");

			$query = $this->mysqli->prepare("INSERT INTO activitylog (date, username, action, additionalinfo, ip) VALUES (?, ?, ?, ?, ?)");
			$query->bind_param("sssss", $date, $username, $action, $additionalinfo, $ip);
			$query->execute();
			$query->close();

			return true;
		}
	}

	/*
	* Hash user's password with SHA512, base64_encode, ROT13 and salts !
	* @param string $password
	* @return string $password
	*/

	function hashpass($password)
	{
		include("config.php");

		$password = hash("SHA512", base64_encode(str_rot13(hash("SHA512", str_rot13($auth_conf['salt_1'] . $password . $auth_conf['salt_2'])))));
		return $password;
	}
}

?>
