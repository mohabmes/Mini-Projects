<?php
class Validate {
  private $_passed = false,
          $_error = array(),
          $_db = null;

  public function __construct(){
    $this->_db = DB::getInstance();
  }

  public function check($source, $items = array()){
    foreach ($items as $item => $rules) {
      foreach ($rules as $rule => $rules_value) {

        $value = trim($source[$item]);
        $item = escape($item);

        if($rule === 'required' && empty($value)){
          $this->addError("{$item} is required");
        }
        else if(!empty($value)) {
          switch ($rule) {
            case 'min':
                if(strlen($value) < $rules_value){
                  $this->addError("{$item} must be minimum of {$rules_value}");
                }
              break;
            case 'max':
                if(strlen($value) > $rules_value){
                  $this->addError("{$item} must be maximum of {$rules_value}");
                }
              break;
            case 'matches':
                if($value != $source[$rules_value]){
                  $this->addError("{$item} must match {$rules_value}");
                }
              break;
            case 'unique':
                $check = $this->_db->get($rules_value, array($item, '=', $value));
                if($check->count()){
                  $this->addError("{$item} already exists.");
                }
              break;
          }
        }
      }
    }
    if(empty($this->_error)){
      $this->_passed = true;
    }
    return $this;
  }

  private function addError($error){
    $this->_error[] = $error;
  }

  public function errors(){
    return $this->_error;
  }

  public function passed(){
    return $this->_passed;
  }

}
