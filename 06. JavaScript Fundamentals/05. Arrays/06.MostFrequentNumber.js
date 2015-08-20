//Write a script that finds the most frequent number in an array.

var i,
    j,
    result,
    counter = 0,
    currentCounter = 1,
    arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    len = arr.length;

for (i = 0; i < len; i+=1) {
    for (j = i+1; j < len; j+=1) {
        if(arr[j]===arr[i]){
            currentCounter+=1;
            result = arr[i];
        }
        if(currentCounter>counter){
            counter = currentCounter;
        }
    }
    currentCounter=0;
}

console.log(result + ' ' + counter + ' (times)');