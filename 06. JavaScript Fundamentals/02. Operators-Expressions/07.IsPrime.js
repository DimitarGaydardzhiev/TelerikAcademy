/**
 * Write an expression that checks if given positive integer number n (n ? 100) is prime.
 */

var arr = [1,2,3,4,9,37,97,51,-3,0];

function isPrime (number) {
    if (number < 2) return false;

    for (var i= 2;i<=Math.sqrt(number);i++){
        if (!(number % i)) return false;
    }
    return true;
}

for (var j= 0;j<arr.length;j++){
    console.log(arr[j] + ' Is Prime? --> ' + isPrime(arr[j]));
}