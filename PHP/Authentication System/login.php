<?php
require_once('core/init.php');

if(Input::exists()){
  if(Token::check(Input::get('token'))){
    $validate = new Validate();
    $validation = $validate->check($_POST, array(
      'username' =>array('required' => true),
      'password' =>array('required' => true)
    ));

    if($validation->passed()){
      //log in  user
      $user = new User();
      $remember = (Input::get('remember') == 'on')? true : false;
      $login = $user->login(Input::get('username'), Input::get('password'), $remember);

      if($login){
        echo "success";
      } else {
        echo "Login failed";
      }
    } else {
      foreach ($validation->errors() as $error) {
        echo $error, '<br>';
      }
    }
  }
}

 ?>
<form action="" method="post">
  <div>
    <label for="username">Username</label>
    <input type="text" name="username">
  </div>
  <div>
    <label for="password">Password</label>
    <input type="password" name="password">
  </div>
  <div>
    <label for="remember">
      <input type="checkbox" name="remember">Remember me
    </label>

  </div>

  <input type="hidden" name="token" value="<?php echo Token::generate(); ?>">
  <input type="submit" value="Log in">
</form>
