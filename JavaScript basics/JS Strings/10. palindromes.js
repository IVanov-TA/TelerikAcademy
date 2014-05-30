function findPolindromes(input) {
    var strBuilder = buildStringBuilder();
    var text = input;
    text = text.toLowerCase();
    text = text.replace(".", " ").replace("!", " ").replace("?", " ").replace(",", " ");
    var wordsArr = text.split(" ");
    for (var i = 0; i < wordsArr.length; i++) {
        strBuilder = buildStringBuilder();
        for (var j = wordsArr[i].length - 1; j >= 0 ; j--) {
            strBuilder.append(wordsArr[i][j]);
        }
        if (strBuilder.toString() == wordsArr[i]) {
            console.log(wordsArr[i]);
        }
    }
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

var test = 'neVen, kAkA';
findPolindromes(test);