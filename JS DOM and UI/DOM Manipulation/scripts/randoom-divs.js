window.onload = function () {

    btnCreator();
    doTheJob();

};

function btnCreator() {
    var button = document.createElement('button');
    button.id = 'div-creator';
    button.value = 1;
    button.textContent = 'Generate ' + button.value + ' Divs';
    document.body.appendChild(button);
}

function doTheJob() {
    var btn = document.getElementById('div-creator'),
        counter = 1;

    btn.addEventListener('click', function() {
        
        for (var i = 0; i < btn.value; i++) {
            var currentItem = createDiv();
            document.body.appendChild(currentItem);
        }

        counter++;
        btn.value = counter;
        btn.textContent = 'Generate ' + btn.value + ' Divs';

        function createDiv() {

            // get browsers width and heght
            var w = window,
             d = document,
             e = d.documentElement,
             g = d.getElementsByTagName('body')[0],
             browserWidth = w.innerWidth || e.clientWidth || g.clientWidth,
             browserHeight = (w.innerHeight || e.clientHeight || g.clientHeight);

            var div = document.createElement('div'),
                strong = createStrong();

            div.appendChild(strong);
            div.style.width = randoomGeneratedNumber(20, 100) + 'px';
            div.style.height = randoomGeneratedNumber(20, 100) + 'px';
            div.style.background = generateRandoomColor() ;
            div.style.color = generateRandoomColor();
            div.style.position = 'absolute';
            div.style.top = randoomGeneratedNumber(0, browserHeight) + 'px';
            div.style.left = randoomGeneratedNumber(0, browserWidth) + 'px';
            div.style.borderWidth = randoomGeneratedNumber(0, 20) + 'px';
            div.style.borderColor = generateRandoomColor();
            div.style.borderStyle = 'solid';
            div.style.borderRadius = randoomGeneratedNumber(0, 90) + 'px';
            return div;
        }

        function createStrong() {
            var strong = document.createElement('strong');
            strong.innerText = 'DIV';
            return strong;
        }

        function randoomGeneratedNumber(min, max) {
            return Math.floor((Math.random() * (max || 255)) + (min || 0));
        }

        function generateRandoomColor() {
            var color = '',
                red = randoomGeneratedNumber(),
                green = randoomGeneratedNumber(),
                blue = randoomGeneratedNumber();
            color = 'rgb(' + red + ', ' + green + ', ' + blue + ')';
            return color;
        }
       
    }, false);
}