<?php
try{
	$db = new PDO('mysql:host=127.0.0.1;dbname=contacts', 'root');
}
catch(Exception $e){
	die("App Error: " . $e->getMessage());
}

class Contact{

	public function getContact($id, $session_id){
		global $db;
		
		$qry = $db->prepare('SELECT * FROM contact WHERE id=:id AND user_id=:user_id');

		$params = [
			'id' => $id,
			'user_id' => $session_id
		];
		$qry->execute($params);
		$result = $qry->fetch(PDO::FETCH_ASSOC);
		return $result;
	}
	
	public function getAllContact($id){
		global $db;
		
		$qry = $db->prepare('SELECT * FROM contact WHERE user_id=:id');
	
		$params = [
			'id' => $id
		];
		$qry->execute($params);
		$result = $qry->fetchAll(PDO::FETCH_ASSOC);
		return $result;
	}
	
	public function updateContact($id, $data = array()){
		global $db;
		
		$sql = 'UPDATE contact SET name=:name, email=:email, mobile=:mobile, country=:country, city=:city, street=:street WHERE id=:id';
		$qry = $db->prepare($sql);

		$params = [
			'name' => $data['name'],
			'email' => $data['email'],
			'mobile' => $data['mobile'],
			'country' => $data['country'],
			'city' => $data['city'],
			'street' => $data['street'],
			'id' => $id
		];
			
		if($qry->execute($params)){
			return true;
		}
		return false;
	}
	
	public function addContact($id, $data = array()){
		global $db;
		
		$qry = $db->prepare('INSERT INTO contact( name, email, mobile, country, city, street, user_id) VALUES ( :name, :email, :mobile, :country, :city, :street, :user_id)');

		$params = [
			'name' => $data['name'],
			'email' => $data['email'],
			'mobile' => $data['mobile'],
			'country' => $data['country'],
			'city' => $data['city'],
			'street' => $data['street'],
			'user_id' => $id
		];
		
		
		if($qry->execute($params)){
			return true;
		}
		return false;
	}
	
	public function deleteContact($id){
		global $db;
		
		$qry = $db->prepare('DELETE FROM contact WHERE id = :id');
				
		$params = [
			'id' => $id
		];
		
		
		if($qry->execute($params)){
			return true;
		}
		return false;
	}
}


class User{
	public function login($username, $password){
		global $db;
		$qry = $db->prepare('SELECT * FROM users WHERE username=:username AND password=:password');
		
		$params = [
			'username' => $username,
			'password' => $password
		];
		$qry->execute($params);
		$user = $qry->fetch(PDO::FETCH_ASSOC);
		return $user;
	}
	
	public function register($user_data = array()){
		global $db;
		
		$qry = $db->prepare('INSERT INTO users( `first_name`, `last_name`, `gender`, `username`, `type`, `password`) VALUES( :first_name, :last_name, :gender, :username, :type, :password)');
				
		$params = [
			'first_name' => $user_data['first_name'],
			'last_name' => $user_data['last_name'],
			'gender' => $user_data['gender'],
			'username' => $user_data['username'],
			'type' => 1,
			'password' => $user_data['password']
		];
		
		if($qry->execute($params)){
			return true;
		}
		return false;
	}
	
	public function update($id, $user_data = array()){
		global $db;
		$sql = 'UPDATE users SET first_name=:first_name, last_name=:last_name, gender=:gender, username=:username, password=:password WHERE id=:id';
		
		$qry = $db->prepare($sql);
		
		$params = [
			'first_name' => $user_data['first_name'],
			'last_name' => $user_data['last_name'],
			'gender' => $user_data['gender'],
			'username' => $user_data['username'],
			'password' => $user_data['password'],
			'id' => $id
		];
		if($qry->execute($params)){
			return true;
		}
		return false;
		
	}
	
	public function getUser($id){
		global $db;
		
		$qry = $db->prepare('SELECT * FROM users WHERE id=:id');

		$params = [
			'id' => $id
		];
		$qry->execute($params);
		$result = $qry->fetch(PDO::FETCH_ASSOC);
		return $result;
	}
}