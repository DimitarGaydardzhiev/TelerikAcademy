/**
 * Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 */

var arr = [5,701,1732,9703,877,7777877,9999799];

function isThirdDigit7 (number) {
    if (number % 10 == 7){
        return true;
    }
    else {
        return false;
    }
}

for (var i = 0; i < arr.length; i++) {
    var result = (arr[i] / 100) | 0;
    console.log(arr[i] + ' --> ' + isThirdDigit7(result));
}



