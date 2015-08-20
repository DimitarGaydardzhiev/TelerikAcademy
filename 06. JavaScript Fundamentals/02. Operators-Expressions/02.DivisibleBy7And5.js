/**
 * Write a boolean expression that checks for given integer if it can be divided (without remainder) by  7  and  5  in the same time.
 */

function checkNumber (number){
    if (number % 5 === 0 && number % 7 === 0) {
        return true;
    }
    else {
        return false;
    }
}

var arr = [3,0,5,7,35,140];

for (var i=0;i<arr.length;i++) {
    console.log('Is ' + (arr[i]) + ' Divided by 7 and 5? --> ' + checkNumber(arr[i]));
}
