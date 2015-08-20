/**
 * Write an expression that checks if given integer is odd or even.
 */


function oddOrEven (number) {
    if (number % 2 === 1 || number % 2 === -1 || number === 0) {
        return false;
    }
    else {
        return true;
    }
}

for (var i = -10; i <= 10; i++) {
    console.log('The number ' + i + ' is even? ' + '-->' + oddOrEven(i))
}
