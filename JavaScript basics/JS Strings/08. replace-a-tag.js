function replace(text) {
    var index = text.indexOf("<a");
    while (index > -1) {
        text = text.replace("<a", "[URL");
        text = text.replace("</a>", "[/URL]");
        index = text.indexOf("<a", index + 1);
    }

    return text;
}

var text = "<p>Please visit <a href='http://academy.telerik. com'>our site</a> to choose a training course. Also visit <a href='www.devbg.org'>our forum</a> to discuss the courses.</p>";
console.log(replace(text));