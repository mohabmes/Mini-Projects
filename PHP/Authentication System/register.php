<?php
require_once('core/init.php');
//
var_dump(Token::check(Input::get('token')));
if(Input::exists() && Token::check(Input::get('token')) ){
    $validate = new Validate();
    $validate = $validate->check($_POST, array(
      'username' => array(
        'required' => true,
        'min' => 2,
        'max' => 20,
        'unique' => 'users'
      ),
      'password' => array(
        'required' => true,
        'min' => 6
      ),
      'password_again' => array(
        'required' => true,
        'matches' => 'password'
      ),
      'name' => array(
        'required' => true,
        'min' => 2,
        'max' => 50
      )
    ));

    if($validate->passed()) {
      $user = new User();
      $salt = Hash::salt(32);
      try {
          $userData = array(
              'name' => Input::get('name'),
              'username' => Input::get('username'),
              'password' => Hash::make(Input::get('password'), $salt),
              'salt' => $salt,
              'joined' => date('Y-m-d H:i:s'),
              'groups' => 1
          );
          $user->create($userData);
          Session::flash('home', 'Welcome ' . Input::get('username') . '! Your account has been registered. You may now log in.');
          header('Location: index.php');

      } catch(Exception $e) {
        die($e->getMessage());
      }
    } else {
      print_r($validate->errors());
    }
}
?>
<form action="" method="post">

  <label for="username">Username</label>
  <input type="text" name="username" value="<?php echo escape(Input::get('username'));?>"><br><br>

  <label for="password">Password</label>
  <input type="password" name="password"><br><br>

  <label for="password_again">Password</label>
  <input type="password" name="password_again"><br><br>

  <label for="name">Name</label>
  <input type="text" name="name" value="<?php echo escape(Input::get('name'));?>"><br><br>

  <input type="hidden" name="token" value="<?php echo Token::generate(); ?>">
  <input type="submit" value="submit">
</form>
