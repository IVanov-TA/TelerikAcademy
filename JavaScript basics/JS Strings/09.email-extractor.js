var text = " While bogi.bogov@abv.bg comes to pe6o.kitarata@gmail.bg i otivat pri joro.lo6oto@yahoo.com ";
console.log(text);

var emailArr = [];
var index = text.indexOf("@");
while (index > -1) {
    if (text[index - 1] != " " && text[index + 1] != " ") {
        var identifier = text.substring(text.lastIndexOf(" ", index - 1), index);
        var host = text.substring(index + 1, text.indexOf(".", index + 1));
        var domain = text.substring(text.indexOf(".", index + 1) + 1, text.indexOf(" ", text.indexOf(".", index + 1) + 1));
        var email = identifier + "@" + host + "." + domain;//it's not working slow for 5 elements
        emailArr.push(email);
        index = text.indexOf("@", index + 1);
    }
}


for (var email in emailArr) {
    console.log(emailArr[email]);
}