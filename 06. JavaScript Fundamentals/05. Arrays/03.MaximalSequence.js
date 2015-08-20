//Write a script that finds the maximal sequence of equal elements in an array.

var i,
    counter = 1,
    currentCounter = 1,
    number = 0,
    arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    len = arr.length;

for (i = 0; i < len; i+=1) {
    if (arr[i]===arr[i+1]){
        currentCounter+=1;
    }
    else {
        currentCounter = 1;
    }

    if (currentCounter >= counter){
        counter = currentCounter;
        number = arr[i];
    }
}

for (i = 0; i < counter; i+=1) {
    console.log(number);
}
