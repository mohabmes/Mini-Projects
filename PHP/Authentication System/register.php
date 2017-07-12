<?php
require_once('core/init.php');
if( Input::exists() && Token::check(Input::get('token')) ){
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

  if($validate->passed()){
    echo "Passed";
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
