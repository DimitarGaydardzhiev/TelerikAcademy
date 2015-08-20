//Write a script that finds the greatest of given 5 variables.
//Use nested  if  statements.

var array1 = [5,2,2,4,1];
var array2 = [-2,-22,1,0,0];
var array3 = [-2,4,3,2,0];
var array4 = [0,-2.5,0,5,5];
var array5 = [-3,-0.5,-1.1,-2,-0.1];

function sort5Numbers (arr){
    var biggest = -1/0; //-Infinity
        i,
        len;

    for (i = 0; len = arr.length, i < len; i+=1) {

        if(arr[i]>biggest){
            biggest = arr[i];
        }
    }
    console.log(biggest)
}

sort5Numbers(array1);
sort5Numbers(array2);
sort5Numbers(array3);
sort5Numbers(array4);
sort5Numbers(array5);
