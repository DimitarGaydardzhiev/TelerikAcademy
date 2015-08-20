//Write a script that finds the maximal increasing sequence in an array.

var i,
    counter= 1,
    currentCounter= 1,
    arr = [3, 2, 3, 4, 2, 8, 4],
    len = arr.length,
    result = [];

for (i = 0; i < len; i+=1) {
    if(arr[i]<arr[i+1]){
        currentCounter+=1;
    }
    else{
        currentCounter=1;
    }
    if(currentCounter>counter){
        counter=currentCounter;
        result.push(arr[i+1]);
        if(counter===2){
            result.unshift(arr[i]);
        }
    }
}

console.log(result.join(', '));