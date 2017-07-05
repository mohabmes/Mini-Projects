<?php

$app->get('/', function ($request, $response, $args){
  $this->view->render($response, 'home.twig');
})->setName('home');

$app->post('/post', function($request, $response, $args) {
	
  $params = $request->getParams();
  
  $hash = md5(uniqid(true));

  $message = $this->db->prepare(
	"INSERT INTO messages(hash, message) 
	VALUES (:hash, :message)
  ");
  $message->execute([
      'hash' => $hash,
      'message' => $params['message']
  ]);


  $this->mail->sendMessage($this->config->get('services.mailgun.domain'), [
          'from' => 'noreply@MAILGUN_DOMAIN.com',
          'to' => $params['email'],
          'subject' => 'New message from Destructy!',
          'html' => $this->view->fetch('email/message.twig', [
              'hash' => $hash,
          ]),
      ]);

	  
  return $response->withRedirect($this->router->pathFor('home'));

})->setName('send');
