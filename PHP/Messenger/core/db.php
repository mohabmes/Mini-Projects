<?php
$dbConfig = $config['db'];
try{
  $db = new PDO("mysql:host={$dbConfig['host']};dbname={$dbConfig['dbname']}", "{$dbConfig['user']}");
} catch(Exception $e) {
  echo $e->getMessage();
}
