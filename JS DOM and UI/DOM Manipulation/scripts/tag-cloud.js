var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js",
    "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js",
    "cms", "html", "javascript", "http", "http", "CMS"];

function generateTagCloud(tags) {
    var currentTagName = '';
    var orderedTags = [];
    var index = 0;

    for (var i = 0; i < tags.length; i++) {
        currentTagName = tags[i].toLowerCase();

        if (checkIfAdded(orderedTags, currentTagName) == true) {
            continue;
        }

        orderedTags.push({ tagName: currentTagName, count: 0 });
        
        for (var j = 0; j < tags.length; j++) {
            if (currentTagName == tags[j].toLowerCase()) {
                orderedTags[index].count++;
            }
        }
        index++;
    }

    return orderedTags;
}

function checkIfAdded(currentTags, currName) {
    var isAvailable = false;
    if (currentTags.length == 0) {
        return false;
    }
    for (var i = 0; i < currentTags.length; i++) {
        var curTagName = currentTags[i].tagName
        if (currName == curTagName) {
                return true;
        }
    }
    return isAvailable;
}
function sortTags(tagCloud) {
    tagCloud.sort(function (a, b) {
        if (a.count < b.count)
            return 1;
        if (a.count > b.count)
            return -1;
        return 0;
    });
}
function drawTag(tagCloud, minFontSize, maxFontSize) {
    var fragmentDiv = document.createDocumentFragment('div');
    for (var i = 0; i < tagCloud.length ; i++) {
        var div = document.createElement("div");
        div.style.position = "absolute";
        div.style.left = random() + "px";
        div.style.top = random() + "px";
        div.innerHTML = tagCloud[i].tagName;
        div.style.fontSize = (maxFontSize-3*i)+"px";
        fragmentDiv.appendChild(div);
    }
    document.body.appendChild(fragmentDiv);
}
function random() {
    return Math.floor((Math.random() * 200) + 0);
}

var tagCloud = generateTagCloud(tags);
sortTags(tagCloud);
drawTag(tagCloud, 17, 42)