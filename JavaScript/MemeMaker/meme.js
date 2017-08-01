
function textChangeListener(event) {

	var id = event.target.id;
	var text = event.target.value;
	
	if(id == "topLineText"){
		window.topLineText = text;
	} else {
		window.bottomLineText = text;
	}
	
	redrawMeme(window.imageSrc, window.topLineText, window.bottomLineText);
}

function redrawMeme(image, topLineText, bottomLineText){

	var c = document.querySelector('canvas');
	var ctx = c.getContext("2d");
	
	if(image != null)
		ctx.drawImage(image, 0,0, c.width, c.height);
		
	ctx.font = '30pt Impact';
	ctx.textAlign = 'center';
	ctx.strokeStyle = 'black';
	ctx.lineWidth = 3;
	ctx.fillStyle = 'white';
	
	if(topLineText != null){
		ctx.fillText(topLineText, c.width / 2, 40);
		ctx.strokeText(topLineText, c.width / 2, 40);
	}
	
	if(bottomLineText != null){
		ctx.fillText(bottomLineText, c.width / 2, c.height - 20);
		ctx.strokeText(bottomLineText, c.width / 2, c.height - 20);
	}
}

function saveFile(){
	window.open(document.querySelector('canvas').toDataURL());
}

function handleFileSelect(event){

	var canvasW = 500;
	var canvasH = 500;
	var file = event.target.files[0];
	
	var reader = new FileReader();
	
	reader.onload = function(fileObj){
	
		var data = fileObj.target.result;
		
		var image = new Image();
		
		image.onload = function(){
		
			window.imageSrc = this;
			redrawMeme(window.imageSrc, null, null);
			
		}
		
		image.src = data;
		//console.log(fileObj.target.result);
	}
	
	reader.readAsDataURL(file);
}

window.topLineText = "";
window.bottomLineText = "";
var input1 = document.getElementById('topLineText');
var input2 = document.getElementById('bottomLineText');
input1.oninput = textChangeListener;
input2.oninput = textChangeListener;
document.getElementById('file').addEventListener('change', handleFileSelect, false);
document.querySelector('button').addEventListener('click', saveFile, false);
