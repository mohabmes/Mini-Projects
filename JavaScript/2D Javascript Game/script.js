	var canvas;		// the canvas element which will draw on
	var ctx;		// the "context" of the canvas that will be used (2D or 3D)
	var x = 30;		// horizontal position of the object (with initial value)
	var y = 270;		// vertical position of the object (with initial value)
	var WIDTH = 1000;	// width of the rectangular area
	var HEIGHT = 340;	// height of the rectangular area
	var sprite = new Image();	// Image to be loaded and drawn on canvas
	var pos = 1;		// display the current position of the character
	var Num_Pos_Walk = 6;	// Number of images that make up the Walking movement
	var Num_Pos_Jump = 14;	// Number of images that make up the Running movement
	var jumpY = 70;		// Length of the Jump 
	var keypress		// Store the pressesd key code
	var jumping = false;
	var Score=0,Advice;
	//==============================================================
	//Background Img Object
	//==============================================================
	var bg = new Image();
	bg.src = "assets/bg3.png";
	var bgX=0;		//Staring X axis point
	var bgY=0;		//Staring Y axis point
	var bgH=HEIGHT;		//Height of bg = height of the canvas
	var bgW=bg.width;	//width of bg = width of the original img
	//==============================================================
	//Coins Class
	//==============================================================
	var Coin = (function() {
		//Image of the Coin
		var coin = new Image();
		coin.src = "assets/coin.png";
		//Position of the Coin ( X axis, Y axis)
		var coinX, coinY;
		//Class Constructor
		function Coin(x, y) {
			this.coinX = x || 0;
			this.coinY = y || 0;
		}
		//Drawing Function
		Coin.prototype = {
			DrawCoin: function() {
				ctx.drawImage(coin, this.coinX, this.coinY, 55,55);
			},
			Check: function(){
				
			}
		};
		return Coin;
	})();
	

	//==============================================================
	// Functions
	//==============================================================
	//Function of (KeyDown) Event
	function KeyDown(event){
		keypress = event.keyCode;
		// right arrow for Walking (D)
		if (keypress == 68) {
			if (pos == Num_Pos_Walk) pos = 1;
			//Change Sonic's sprite
			pos++;
			//Number of the steps on The X axis
			bgX -=4;
		}
		// down arrow for running (S)
		if (keypress == 83) {
			if(pos == Num_Pos_Jump) pos = 7;
			//Change Sonic's sprite
			pos++;
			//Number of the steps on The X axis
			bgX -=8;
		}
		// up arrow for jumping (W)
		if (keypress == 87) {
			//Change Sonic's sprite
			pos = 77;
			//Number of the steps on The X axis
			bgX -=80;
			jumping = true;
		}

	}
	//Function of (KeyUp) Event
	function KeyUp(event){
		//when the user stop pressing any key change Sonic's sprite to the original one 
		pos=1;
		
	}
	//Function that draws on the canvas
	function Draw() {
		//First Draw the background with the last value of bgX
		ctx.drawImage(bg, bgX, 0 );
		ctx.closePath();
		//if the background reach to the end start over again
		if (bgX <= -1500){bgX=0;}
		//if user press jump
		if (keypress == 87){
			//Change keypress value to zero to prevent sonic from keep jumping
			keypress =0;
			//Change sonic's sprite to the jumping Form
			jumping = true;
			//Finally Call Jump function
			Jump();
		}
		else{
			//Coins Object Creation
			//==============================================================
			var coin1 = new Coin(700+bgX, 85);
			coin1.DrawCoin();
			if( coin1.coinX>=55 &&  coin1.coinX<=72 ){
				Score++;
				document.getElementById("score").innerHTML = "collision";
			}
			
			var coin2 = new Coin(1200+bgX,300);
			coin2.DrawCoin();
			if( coin2.coinX>=55 &&  coin2.coinX<=72 ){
				Score++;
				document.getElementById("score").innerHTML = "collision";
			}
			//==============================================================
			//assigning sprite image source with the last updated value
			sprite.src = "assets/"+ pos +".png";
			//Draw it - with x,y axis values
			ctx.drawImage(sprite, x, y);
		}
		

	}
	//Function for Clearing
	function CleanScreen() {
	    ctx.fillStyle = "rgb(233,233,233)";    
	    ctx.beginPath();
	    ctx.rect(0, 0, WIDTH, HEIGHT);
	    ctx.closePath();
	    ctx.fill();    
	}
	//Function for updating by clear and redraw
	function Update() {
	    //Clear first
	    CleanScreen();
	    //Draw
	    Draw();
	}
	function Start() {
		//canvas initialization 
	    canvas = document.getElementById("canvas");
	    ctx = canvas.getContext("2d");
	    //Call Update Function each 100MS
	    setInterval(Update, 100);
	}
	//Function for jumping
	function Jump(){
		pos = 77;
		//prevent the user from controlling while jumping
		window.removeEventListener('keydown', KeyDown);
		window.removeEventListener('keyup', KeyUp);
		//Check the value of jumping
		if(jumping){
			//set jumping to false after jumping
			jumping=false;
			//Draw
			sprite.src = "assets/"+ pos +".png";
			ctx.drawImage(sprite, x, jumpY);
			
			//Call land Function after 10MS
			setInterval(land,10);pos = 1;
		}
	}
	//Function for landing
	function land(){
		//set jumping to false after jumping
		jumping=false;
		//return controlling EventListener after jumping
		window.addEventListener('keydown', KeyDown);
		window.addEventListener('keyup', KeyUp);
	}


	//first, Add EventListener for KeyDown and KeyUp
	window.addEventListener('keydown', KeyDown);
	window.addEventListener('keyup', KeyUp);
	//Start();
