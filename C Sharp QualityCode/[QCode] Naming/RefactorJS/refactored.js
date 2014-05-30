function buttonClicked(evnt, args) {
    var currentWindows = window;
    var userAgent = currentWindows.navigator.appCodeName;
    var isMozilla = userAgent == "Mozilla";
    if (isMozilla) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}