//Write a script that reads the coefficients  a ,  b  and  c  of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.


function solveQuadraticEquation (a,b,c) {
    var D = (Math.pow(b,2)) - (4*a*c);
    var x1 = ((-b) - (Math.sqrt((Math.pow(b,2)) - (4*a*c))))/(2*a);
    var x2 = ((-b) + (Math.sqrt((Math.pow(b,2)) - (4*a*c))))/(2*a);

    if (D<0){
        console.log('no real roots');
    }
    else if (D===0){
        console.log('x1=x2=', x1);
    }
    else {
        console.log('x1=' + x1 + ';' + 'x2=' + x2);
    }
}

solveQuadraticEquation(2,5,-3);
solveQuadraticEquation(-1,3,0);
solveQuadraticEquation(-0.5,4,-8);
solveQuadraticEquation(5,2,8);