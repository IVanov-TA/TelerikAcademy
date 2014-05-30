var sometext = new String(' U aRE 4mIZinG ! ! ! ');
console.log(replaceAllWhiteSpaces(sometext, '&nbsp'));


function replaceAllWhiteSpaces(text, newSymbol) {
    var result = '';
    for (var i = 0; i < text.length; i++) {
        if (text[i] == ' ') {
            result += newSymbol;
        }
        else {
            result += text[i];
        }
    }
    return result;
}