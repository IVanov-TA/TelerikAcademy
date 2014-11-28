function raphael() {
    var paper = Raphael('container', 800, 300);
    return paper;
}

function drawTelerikLogo() {
    var paper = raphael();
    logo = paper.path("M 30 105 L 70 70 L 133 143 L 95 178 L 62 142 L 137 70 L 170 105")
	.attr({
	    fill: "none",
	    "stroke-width": 18,
	    stroke: '#5CE600',
	});
    var text = paper.text(420, 150, "Telerik");
    text.attr({ "font-family": "arial", fill: "black", "font-size": 142, "font-weight": "bold" });
    var subText = paper.text(505, 230, "Develop experiences");
    subText.attr({ "font-family": "arial", fill: "black", "font-size": 60 });

    var img = paper.image("img/symbol.png", 640, 125, 30, 30);
}

function drawYoutubeLogo() {
    var paper = raphael();
    var rect = paper.rect(300, 50, 360, 200, 50);
    rect.attr({
        fill: "#EC2828",
        stroke: "#EC2828"
    });
    var textYou = paper.text(170, 150, "You");
    textYou.attr({ "font-family": "Arial", fill: "black", "font-size": 142, "font-weight": "bold" });
    var textTube = paper.text(480, 150, "Tube");
    textTube.attr({ "font-family": "Arial", fill: "white", "font-size": 142, "font-weight": "bold" });
}