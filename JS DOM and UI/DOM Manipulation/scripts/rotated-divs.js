window.onload = function () {
    var dFrag = document.createDocumentFragment(),
        circleRadius = document.getElementById('cirlce-radius'),
        refreshTime = document.getElementById('speed-rotation'),
        reverse = document.getElementById('reversed'),
        w = window,
        d = document,
        e = d.documentElement,
        g = d.getElementsByTagName('body')[0],
        width = w.innerWidth || e.clientWidth || g.clientWidth,
        height = w.innerHeight || e.clientHeight || g.clientHeight,

        centerPoint = {
            x: width / 2,
            y: height / 2,
            angle: 0.01,
            radius: circleRadius.value
        };

    for (var i = 0; i < 5; i++) {
        var item = generateDiv(0, 0);
        dFrag.appendChild(item);
    }

    document.body.appendChild(dFrag);

    var divs = document.getElementsByTagName('div');


    var myTimer;

    function animataFrame() {

        var speed = (100 - refreshTime.value) + 10;

        if (reverse.checked) {
            centerPoint.angle -= 0.1;
        } else {
            centerPoint.angle += 0.1;
        }

        centerPoint.radius = circleRadius.value;

        for (var i = 0; i < divs.length; i++) {
            var currentAngle = centerPoint.angle + i * 2 * Math.PI / 5;
            var x = centerPoint.y + centerPoint.radius * Math.sin(currentAngle),
            y = centerPoint.x + centerPoint.radius * Math.cos(currentAngle);
            divs[i].style.top = x + 'px';
            divs[i].style.left = y + 'px';
        }
        clearInterval(myTimer);
        myTimer = setInterval(animataFrame, speed);
    }

    animataFrame();

    function generateDiv(top, left) {
        var div = document.createElement('div');
        div.style.border = '1px solid black';
        div.style.width = '30px';
        div.style.height = '30px';
        div.style.position = 'absolute';
        div.style.top = top + 'px';
        div.style.left = left + 'px';
        return div;
    }
}
