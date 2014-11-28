function createTextArea() {
    var txtArea = document.createElement("textarea");
    txtArea.style.position = "absolute";
    txtArea.style.left = 10 + 'px';
    txtArea.style.top = 100 + 'px';
    txtArea.style.color = getFontColor();
    txtArea.style.backgroundColor = getBackgroundColor();
    document.body.appendChild(txtArea);
}

function createInputForBackground() {

    var inputColor = document.createElement("input");
    inputColor.type = "color";
    inputColor.style.position = "absolute";
    inputColor.id = "font";
    inputColor.style.left = 10 + 'px';
    inputColor.style.top = 60 + 'px';
    document.body.appendChild(inputColor);

}
function createInputForFont() {

    var inputColor = document.createElement("input");
    inputColor.type = "color";
    inputColor.style.position = "absolute";
    inputColor.id = "ground";
    inputColor.style.left = 210 + 'px';
    inputColor.style.top = 60 + 'px';
    document.body.appendChild(inputColor);

}
function getFontColor() {
    return document.getElementById("ground").value;
}
function getBackgroundColor() {
    return document.getElementById("font").value;
}
createInputForFont();
createInputForBackground();
createTextArea();