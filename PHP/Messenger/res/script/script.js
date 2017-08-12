function showLogin(){
  document.getElementById('loginbox').style.display = "inline-block";
  document.getElementById('whitebg').style.display = "inline-block";
}

function hideLogin(){
  document.getElementById('loginbox').style.display = "none";
  document.getElementById('whitebg').style.display = "none";
}

function setUsername(){
  var user = document.getElementById('cusername').value;
  document.cookie = "username=" + user;
  checkCookie();
}

function checkCookie(){
  if(document.cookie.indexOf('username') == -1){
    showLogin();
  } else {
    hideLogin();
  }
}
