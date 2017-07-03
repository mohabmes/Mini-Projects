<?php

$app->get('/', function ($request, $response, $args){
  //echo $this->config->get('db.mysql.dbname');
  $this->view->render($response, 'home.twig');
});
