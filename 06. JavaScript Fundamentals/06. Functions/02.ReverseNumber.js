//Write a function that reverses the digits of given decimal number.

var number = 123.45;

function reverseNumber (N) {
    N += '';
    var i,
        len = N.length;
    arr = [];

    for (i = 0; i < len; i += 1) {
        arr.push(N[i]);
    }
    arr.reverse();
    console.log(arr.join(''));
}

reverseNumber(number);

