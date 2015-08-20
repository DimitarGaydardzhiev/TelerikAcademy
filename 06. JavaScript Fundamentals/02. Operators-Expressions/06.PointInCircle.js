/**
 * Write an expression that checks if given point  P(x, y)  is within a circle  K({0,0}, 5) . //{0,0} is the centre and 5 is the radius
 */
var arrX = [0,-5,-4,1.5,-4,100,0,0.2,0.9,2];
var arrY = [1,0,5,-3,-3.5,-30,0,-0.8,-4.93,2.655];

function pointInCircle (xcoord, ycoord){
    if ((Math.pow((0-xcoord),2)+Math.pow((0-ycoord),2))<=25){
        return true;
    }
    else {
        return false;
    }
};

for (i=0;i<arrX.length;i++){
    console.log(arrX[i] + ' ' + arrY[i] + '-->' + pointInCircle(arrX[i],arrY[i]));
}


