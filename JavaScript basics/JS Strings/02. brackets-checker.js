function dealTheTaks(input) {

    var openBracket = 0;
    var closedBracket = 0;

    for (var i = 0; i < input.length; i++) {
        var currentChar = input[i];

        if (currentChar === '(') {
            openBracket++;
            closedBracket--;
        }
        if (currentChar === ')') {
            openBracket--;
            closedBracket++;
        }
    }

    if ((openBracket - closedBracket) === 0) {
        console.log('Correctly puted !!!');
    } else {
        console.log('You try to cheat...');
    }

}

var test1 = '(34 + ((11-7) * (34-5)))';

console.log(dealTheTaks(test1));