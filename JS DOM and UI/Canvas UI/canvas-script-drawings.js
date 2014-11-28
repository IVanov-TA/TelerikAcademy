window.onload = function drawScene() {
    var canvas = document.getElementById('drawing-field'),
        ctx = canvas.getContext('2d');

    drawHead();
    drawCylinder();
    drawBike();
    ctx.translate(750, 0);
    drawHouse();

    function drawHouse() {
        ctx.save();
        ctx.fillStyle = '#955959';
        ctx.strokeStyle = 'black';

        // draw body of the house and the roof
        ctx.fillRect(0, 300, 350, 300);
        ctx.strokeRect(0, 300, 350, 300);
        ctx.beginPath();
        ctx.moveTo(0, 300);
        ctx.lineTo(175, 90);
        ctx.lineTo(350, 300);
        ctx.fill();
        ctx.stroke();

        // draw the chimney
        ctx.beginPath();
        ctx.moveTo(250, 250);
        ctx.lineTo(250, 130);
        ctx.lineTo(280, 130);
        ctx.lineTo(280, 250);
        ctx.fill();
        ctx.stroke();
        ctx.save();
        ctx.translate(250, 0);
        drawElipse(10, 160, 10, 0, 2 * Math.PI, 1.5, 0.8);
        ctx.restore();

        // draw the windows
        ctx.beginPath();
        drawWindow(30, 330, 120, 90);
        drawWindow(200, 330, 120, 90);
        drawWindow(200, 450, 120, 90);

        // draw the door
        ctx.beginPath();
        ctx.moveTo(40, 600);
        ctx.lineTo(40, 500);
        ctx.quadraticCurveTo(90, 450, 140, 500);
        ctx.lineTo(140, 500);
        ctx.lineTo(140, 600);
        ctx.stroke();
        ctx.beginPath();
        ctx.moveTo(90, 600);
        ctx.lineTo(90, 475);
        ctx.stroke();

        ctx.beginPath();
        ctx.arc(70, 560, 5, 0, 2 * Math.PI);
        ctx.stroke();
        ctx.closePath();
        ctx.beginPath();
        ctx.arc(110, 560, 5, 0, 2 * Math.PI);
        ctx.stroke();

        ctx.restore();
    }

    function drawWindow(positionX, positionY, width, height) {
        ctx.save();
        ctx.fillStyle = 'black';
        ctx.strokeStyle = '#955959';
        ctx.fillRect(positionX, positionY, width, height);
        ctx.moveTo(positionX, positionY + height / 2);
        ctx.lineTo(positionX + width, positionY + height / 2);
        ctx.moveTo(positionX + width / 2, positionY);
        ctx.lineTo(positionX + width / 2, positionY + height);
        ctx.stroke();
        ctx.restore();
    }

    function drawBike() {
        drawElipse(300, 500, 70, 0, 2 * Math.PI, 1, 1);
        drawElipse(600, 500, 70, 0, 2 * Math.PI, 1, 1);
        ctx.beginPath();
        ctx.moveTo(300, 500);
        ctx.lineTo(430, 500);
        ctx.lineTo(580, 410);
        ctx.lineTo(380, 410);
        ctx.closePath();
        ctx.stroke();

        ctx.save();
        ctx.fillStyle = 'transparent';
        drawElipse(430, 500, 20, 0, 2 * Math.PI, 1, 1);
        ctx.restore();
        ctx.beginPath();

        // draw the steering wheel
        ctx.moveTo(600, 500);
        ctx.lineTo(570, 350);
        ctx.lineTo(620, 300);
        ctx.moveTo(570, 350);
        ctx.lineTo(520, 380);

        // 
        ctx.moveTo(430, 500);
        ctx.lineTo(360, 380);
        ctx.moveTo(320, 380);
        ctx.lineTo(400, 380);

        ctx.moveTo(400, 480);
        ctx.lineTo(415, 490);
        ctx.moveTo(445, 510);
        ctx.lineTo(460, 520);
        ctx.stroke();
    }

    function drawCylinder() {
        ctx.save();
        ctx.strokeStyle = 'black';
        ctx.fillStyle = '#396693';
        drawElipse(100, 610, 50, (310 * (Math.PI / 180)), (240 * (Math.PI / 180)), 2, 0.3);
        ctx.moveTo(150, 70);
        ctx.lineTo(150, 170);
        // ctx.lineTo(240, 180);
        ctx.quadraticCurveTo(200, 200, 265, 172);
        ctx.lineTo(265, 70);
        ctx.fill();
        ctx.stroke();
        ctx.moveTo(208, 70);
        drawElipse(148, 140, 40, 0, 2 * Math.PI, 1.4, 0.5);
        ctx.restore();
    }

    function drawHead() {
        // head Elipse
        ctx.lineWidth = '3';
        ctx.fillStyle = '#90CAD7';
        ctx.strokeStyle = '#317B8D';

        drawElipse(150, 250, 70, 0, 2 * Math.PI, 1.3, 1);

        // draw left & right eye
        drawElipse(90, 220, 10, 0, 2 * Math.PI, 1.6, 1);
        drawElipse(130, 220, 10, 0, 2 * Math.PI, 1.6, 1);
        ctx.save();
        ctx.fillStyle = '#317B8D';
        // those are the iris of the eye
        drawElipse(175, 170, 5, 0, 2 * Math.PI, 0.8, 1.3);
        drawElipse(255, 170, 5, 0, 2 * Math.PI, 0.8, 1.3);
        ctx.restore();

        // draw mouth
        ctx.save();
        ctx.rotate(10 * Math.PI / 180);
        ctx.translate(90, 0);
        drawElipse(80, 500, 25, 0, 2 * Math.PI, 1.6, 0.5);
        ctx.restore();
        // draw nouse
        ctx.moveTo(175, 220);
        ctx.lineTo(155, 255);
        ctx.lineTo(175, 255);
        ctx.stroke();
    }

    function drawElipse(positionX, positionY, radius, startAngle, endAngle, scaleX, scaleY) {
        ctx.beginPath();
        ctx.save();
        ctx.scale(scaleX, scaleY);
        ctx.arc(positionX, positionY, radius, startAngle, endAngle);
        ctx.fill();
        ctx.stroke();
        ctx.restore();
    }
};