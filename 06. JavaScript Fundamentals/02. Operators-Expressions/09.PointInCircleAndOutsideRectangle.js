/**
 * Write an expression that checks for given point  P(x, y)  if it is within the circle  K( (1,1), 3)  
 * and out of the rectangle  R(top=1, left=-1, width=6, height=2) .
 */

var X = [1,2.5,0,2.5,2,4,2.5,2,1,-100];
var Y = [2,2,1,1,0,0,1.5,1.5,2.5,-100];
var result = '';

function isInsideACircle (x,y) {
    return (((Math.pow((x-1),2)) + (Math.pow((y-1),2))) <= 9);
}

function isInsideARectangle (x,y) {
    return !(x <= 5 && x >= -1 && y >= -1 && y <= 1);
}

for (var i = 0; i < X.length; i++) {
    var isInACircle = isInsideACircle(X[i],Y[i]);
    var isInARec = isInsideARectangle(X[i],Y[i]);

    if (isInACircle === true && isInARec === true) {
        result = 'Yes';
    }
    else {
        result = 'No';
    }

    console.log('Point(' + X[i] + ', ' + Y[i] + ') ' + 'is inside K & outside of R --> ' + result);
}