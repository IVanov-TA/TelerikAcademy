function pritnTheSubstitute(text, words) {
    var wordsArr = words.split(",");
    var formated = stringFormat(text, wordsArr);
    console.log(formated);
}
function stringFormat(text, wordsArr) {
    var strB = buildStringBuilder();
    var beggining = 0;
    var index = text.indexOf("{");
    while (index > -1) {
        var number = parseInt(text.substr(index + 1, 1));
        strB.append(text.substring(beggining, index - 1) + " ");
        strB.append(wordsArr[number] + " ");
        beggining = index + 3;
        index = text.indexOf("{", index + 1);
    }
    return strB.toString();
}
function buildStringBuilder() {
    return {
        strs: [],
        len: 0,
        append: function (str) {
            this.strs[this.len++] = str;
            return this;
        },
        toString: function () {
            return this.strs.join("");
        }
    };
}


var str = stringFormat('Hello {0}!');
var word = 'Peter';pritnTheSubstitute(str, word);