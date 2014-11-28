function drawCanvas() {
    var canvas = document.getElementById('canvas-board'),
        ctx = canvas.getContext('2d'),
        width = canvas.scrollWidth,
        height = canvas.scrollHeight,
        x = 70,
        y = 70,
        speedX = 10,
        speedY = 10,
        speed = 10;

    function animateCyrcle() {
        if (x + 60 >= width) {
            speedX = -getRandomNumber();
        }

        if (x <= 60) {
            speedX = getRandomNumber();
        }

        if (y + 60 >= height) {
            speedY = -getRandomNumber();
        }

        if (y <= 60) {
            speedY = getRandomNumber();
        }

        ctx.clearRect(0, 0, canvas.clientWidth, canvas.clientHeight);

        ctx.fillStyle = '#cf0';
        ctx.beginPath();
        ctx.arc(x, y, 60, 0, 2 * Math.PI);
        ctx.fill();
        ctx.stroke();

        x += speedX;
        y += speedY;

        requestAnimationFrame(animateCyrcle);
    }

    function getRandomNumber() {
        return (Math.floor(Math.random() * 7) + 3);
    }

    animateCyrcle();
}