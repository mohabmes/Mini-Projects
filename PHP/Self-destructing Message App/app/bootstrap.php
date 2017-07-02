<?php

require("../vendor/autoload.php");

$container = new \Slim\Container;

$container['config'] = function($container){
  return new \Noodlehaus\Config('../config/app.php');
};

$app = new \Slim\App($container);

require("routes.php");
