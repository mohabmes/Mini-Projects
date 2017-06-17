<?php
function esc($text){
  return htmlspecialchars($text, ENT_QUOTES);
}
