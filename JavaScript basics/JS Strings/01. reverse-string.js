function dealTheTask(input) {

    var reversed = '';

    for (var i = input.length - 1 ; i >= 0; i -= 1) {
        reversed += input[i];
    }

    return reversed;

}

var test = "abcdefghijklmnopqrstuvwxyz";

console.log('Starting with: ' + test);

console.log('Reversed: ' + dealTheTask(test));