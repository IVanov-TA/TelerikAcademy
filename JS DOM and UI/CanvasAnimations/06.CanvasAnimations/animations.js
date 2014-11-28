var canvas, ctx, sprites,
rightKey = false,
leftKey = false,
upKey = false,
downKey = false,
x = 25, y = 455, width = 90, height = 115, srcX = 0, srcY = 0;

function clearCanvas() {
    ctx.clearRect(0, 0, 1000, 800);
}
function drawShip() {
    if (rightKey) {
        x += 5;
        srcX = 80;
    } else if (leftKey) {
        x -= 5;
        srcX = 80;
    }

    ctx.drawImage(sprites, srcX, srcY, width, height, x, y, width, height);
    if (rightKey == false || leftKey == false) {
        srcX = 0;
    }
}

function loop() {
    clearCanvas();
    drawShip();
}
function keyDown(e) {
    if (e.keyCode == 39) rightKey = true;
    else if (e.keyCode == 37) leftKey = true;
}
function keyUp(e) {
    if (e.keyCode == 39) rightKey = false;
    else if (e.keyCode == 37) leftKey = false;
}
(function init() {
    canvas = document.getElementById('canvas');
    ctx = canvas.getContext('2d');
    sprites = new Image();
    sprites.src = 'img/walk.png';
    setInterval(loop, 1000 / 30);
    document.addEventListener('keydown', keyDown, false);
    document.addEventListener('keyup', keyUp, false);
})();

