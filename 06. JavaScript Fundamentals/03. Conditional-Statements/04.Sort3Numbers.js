//Sort 3 real values in descending order.
// Use nested  if  statements.

function sort (a,b,c) {
    if (a>b){
        if (a>c){
            if(b > c){
                console.log(a,b,c);
            }
            else{
                console.log(a,c,b);
            }
        }
        else {
            console.log(c,a,b);
        }
    }
    else {
        if (b>c){
            if(a > c){
                console.log(b,a,c);
            }
            else{
                console.log(b,c,a);
            }
        }
        else {
            console.log(c,b,a);
        }
    }
}

sort(-1,0,4);
sort(34,5,6);
sort(1,2,3);