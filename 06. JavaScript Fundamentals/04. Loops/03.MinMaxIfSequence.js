//Write a script that finds the  max  and  min  number from a sequence of numbers.

var arr = [-1,2,3,2,0,5,17,-22];

var i,
    len = arr.length,
    min = 1/0, //+infinity
    max = -1/0; //-infinity

for (i = 0; i < len; i+=1) {
    if(arr[i]<min){
        min = arr[i];
    }
    if(arr[i]>max){
        max = arr[i];
    }
}

console.log('min = ' + min + ', ' + 'max = ' + max);