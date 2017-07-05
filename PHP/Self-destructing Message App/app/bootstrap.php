<?php

require("../vendor/autoload.php");

$container = new \Slim\Container;

$container['config'] = function($container){
  return new \Noodlehaus\Config('../config/app.php');
};

$container['view'] = function($container){
  $view = new \Slim\Views\Twig('../resources/views');

  $view->addExtension(new \Slim\Views\TwigExtension(
    $container['router'],
    $container['config']->get('url')
    )
  );
  return $view;
};


$container['db'] = function($container){
  return new PDO(
        'mysql:host=' . $container['config']->get('db.mysql.host') . 
		';dbname=' . $container['config']->get('db.mysql.dbname'),
        $container['config']->get('db.mysql.username')
        //,$container['config']->get('db.mysql.password')
    );
};

$app = new \Slim\App($container);

require("routes.php");
