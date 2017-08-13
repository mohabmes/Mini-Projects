<?php
session_start();

ini_set('display_errors', 'On');

define('CORE',    __DIR__);
define('APP',     './app/');
define('VIEWS',   './app/views/');
define('RES',     './res/');
define('BASE_URL','http://localhost/Messenger');

require_once('config.php');
require_once('db.php');
