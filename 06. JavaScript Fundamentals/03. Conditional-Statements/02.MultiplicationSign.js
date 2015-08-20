//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//• Use a sequence of  if  operators.


var a = -10,
    b = 2.5,
    c = -4,
    counter = 0;

if (a===0||b===0||c===0){
    console.log(0);
}
else {
    if (a<0) {
        ++counter;
    }
    if(b<0) {
        ++counter;
    }
    if(c<0){
        ++counter;
    }
    if (counter === 0){
        console.log('+');
    }
}
if (counter === 1 || counter === 3){
    console.log('-');
}
else if(counter!=0){
    console.log('+');
}

