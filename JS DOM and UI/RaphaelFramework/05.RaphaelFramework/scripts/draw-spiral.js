window.onload = function () {
    var paper = Raphael('container', 400, 400);
    drawSpiral(paper, 200, 150, 1, 1);
}

function drawSpiral(raphael, centerX, centerY, a, b) {
    var paper = raphael;
    var center = "M" + centerX + ' ' + centerY;
    var spiral = center;

    for (var i = 0; i < 720; i++) {
        angle = 0.2 * i;
        x = centerX + (a + b * angle) * Math.cos(angle);
        y = centerY + (a + b * angle) * Math.sin(angle);
        spiral += 'L ' + x + ' ' + y;
    }

    paper.path(spiral);
}