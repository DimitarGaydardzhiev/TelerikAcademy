//• Sorting an array means to arrange its elements in increasing order.
//• Write a script to sort an array.
//• Use the selection sort algorithm: Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.

var i,
    j,
    min,
    temp,
    arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    len = arr.length;

for (i = 0; i < len; i+=1) {
    min = i;
    for (j = i+1; j < len; j+=1) {
        if (arr[j]<arr[min]){
            min = j;
        }
    }
    temp = arr[i];
    arr[i] = arr[min];
    arr[min]=temp;
}

console.log(arr.join(', '));