//• Write functions for working with shapes in standard Planar coordinate system.
//? Points are represented by coordinates P(X, Y)
//? Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//• Calculate the distance between two points.
//• Check if three segment lines can form a triangle.

function makePoint(x, y) {
    return {
        x: x,
        y: y
    };
}

function makeLine(firstPoint, secondPoint) {
    return {
        point1: firstPoint,
        point2: secondPoint,
        length: pointDistance(firstPoint, secondPoint)
    };
}

function pointDistance(point1, point2) {
    var dx = point1.x - point2.x;
    var dy = point1.x - point2.y;
    return Math.sqrt(Math.pow(dx, 2) + Math.pow(dy, 2))
}

function isTriangle(point1, point2, point3) {
    var a = makeLine(point1, point2);
    var b = makeLine(point1, point3);
    var c = makeLine(point2, point3);

    if ((a.length + b.length) > c.length) {
        console.log(true);
    }
    else if ((a.length + c.length) > b.length) {
        console.log(true);
    }
    else if ((b.length + c.length) > a.length) {
        console.log(true);
    }
    else {
        console.log(false);
    }
}

var firstPoint = makePoint(1, -2);
var secondPoint = makePoint(3,2);
var thirdPoint = makePoint(9,0);

var firstLine = makeLine(firstPoint, secondPoint);
var secondLine = makeLine(firstPoint, thirdPoint);
var thirdLine = makeLine(secondPoint, thirdPoint);

console.log(firstLine.length.toFixed(2));
console.log(secondLine.length.toFixed(2));
console.log(thirdLine.length.toFixed(2));

isTriangle(firstPoint, secondPoint, thirdPoint);

