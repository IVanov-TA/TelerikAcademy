function getInnerDivs(){
	var divCollection = document.getElementsByTagName('div');
	for (var i = 0, len = divCollection.length; i < len; i += 1) {
		if (divCollection[i].parentNode instanceof HTMLDivElement) {
			console.log(divCollection[i].innerText);
		}
	}
}

function getData(){
	var textBox = document.querySelector('input[type="text"]');
	if (textBox.value) {
		console.log(textBox.value);
	}else{
		console.log('!<NO DATA>!')
	} ;
}

function setBackgroundColor(){
	var colorBox = document.querySelector('input[type="color"]');
	console.log('Color: ' +  colorBox.value);
	document.body.style.backgroundColor  = colorBox.value.toString();
}