function countAppearances(text, sub) {
    text = text.toLowerCase();
    sub = sub.toLowerCase();
    var indexOfSub = text.indexOf(sub);
    var count = 0;
    while (indexOfSub > -1) {
        count++;
        indexOfSub = text.indexOf(sub, indexOfSub + 1);
    }

    return count;
}



var test = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."

var sub = 'in';

var getCount = countAppearances(test, sub);

console.log(getCount);