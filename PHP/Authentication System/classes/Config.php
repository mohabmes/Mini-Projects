<?php
class Config{
  public static function get($path = null){
    if($path){
      $path = explode('/', $path);
      $config = $GLOBALS['config'];

      foreach ($path as $key) {
        if(isset($config[$key])){
          $config = $config[$key];
        }
      }
      return $config;
    }
    return false;
  }
}
