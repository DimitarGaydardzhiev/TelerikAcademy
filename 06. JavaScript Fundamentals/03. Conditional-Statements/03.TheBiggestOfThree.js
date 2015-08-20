//Write a script that finds the biggest of three numbers.
//• Use nested  if  statements.

var a = 5,
    b = 3,
    c = -2,
    biggest = '';

if (a>b){
    biggest = a;
    if (biggest>c){
        console.log(biggest);
    }
    else{
        biggest = c;
        console.log(biggest);
    }
}
else {
    biggest = b;
    if (biggest>c){
        console.log(biggest);
    }
    else{
        biggest = c;
        console.log(biggest);
    }
}
