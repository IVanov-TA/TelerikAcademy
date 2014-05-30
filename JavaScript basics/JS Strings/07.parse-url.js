
function parseURL(input) {
    var url = input;
    var protokol = url.substring(0, url.indexOf(":"));
    var server = url.substring(url.indexOf(":") + 3, url.indexOf("/", url.indexOf(":") + 3));
    var resource = url.substr(url.indexOf("/", url.indexOf(":") + 3) + 1)
    var URLJSON = { "Protokol": protokol, "Server": server, "Resource": resource };
    console.log("Protokol :" + URLJSON.Protokol);
    console.log("Server :" + URLJSON.Server);
    console.log("Resource :" + URLJSON.Resource);
}

var test = 'http://www.devbg.org/forum/index.php';

parseURL(test);