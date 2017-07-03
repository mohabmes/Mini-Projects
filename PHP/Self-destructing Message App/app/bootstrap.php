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

$app = new \Slim\App($container);

require("routes.php");
