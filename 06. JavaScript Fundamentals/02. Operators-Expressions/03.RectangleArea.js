/**
 * Write an expression that calculates rectangle’s area by given width and height.
 */

var firstArea = {
    width: 3,
    height: 4
};

var secondArea = {
    width: 2.5,
    height: 3
};

var thirdArea = {
    width: 5,
    height: 5
};

function calculateArea (width, heigth) {
    var area = width*heigth;
    return area;
};

console.log('Rectangle\'s area with width: ' + firstArea.width + ' and height ' + firstArea.height + ' is: ' + calculateArea(firstArea.width,firstArea.height));
console.log('Rectangle\'s area with width: ' + secondArea.width + ' and height ' + secondArea.height + ' is: ' + calculateArea(secondArea.width,secondArea.height));
console.log('Rectangle\'s area with width: ' + thirdArea.width + ' and height ' + thirdArea.height + ' is: ' + calculateArea(thirdArea.width,thirdArea.height));