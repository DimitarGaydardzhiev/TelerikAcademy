/**
 * Write an expression that calculates trapezoid's area by given sides  a  and  b  and height  h .
 */

var sideA = [5,2,8.5,100,0.222];
var sideB = [7,1,4.3,200,0.333];
var heightH = [12,33,2.7,300,0.555];

function getArea (a,b,h) {
    var result = ((a+b)/2)*h;
    return (parseFloat(result.toPrecision(7)))
}

for (i=0;i<sideA.length;i++) {
    console.log('Trapezoid area with side a= ' + sideA[i] + ' , side b= ' + sideB[i]
        + ' and height h= ' + heightH[i] + ' is --> ' + getArea(sideA[i],sideB[i],heightH[i]));
}