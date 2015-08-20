/**
 • Write a boolean expression for finding if the bit  #3  (counting from 0) of a given integer.
 • The bits are counted from right to left, starting from bit  #0 .
 • The result of the expression should be either  1  or  0 .
 */


function checkBit (number) {
    return (number >> 3) & 1;
}

console.log(checkBit(5));
console.log(checkBit(8));
console.log(checkBit(0));
console.log(checkBit(15));
console.log(checkBit(5343));
console.log(checkBit(62241));
