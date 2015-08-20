//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var arr = [15,2,13,8,6,7,8,9,5,22,87,0],
    value = 15,
    start = 0,
    end = arr.length - 1,
    mid = 0;

function sortNumber(a,b) {
    return a - b;
}

arr.sort(sortNumber);
console.log(arr);

while (start <= end) {
    mid = Math.floor((start + end) / 2);

    if (arr[mid] < value) {
        start = mid + 1;
    } else if (arr[mid] > value) {
        end = mid - 1;
    } else  {
        console.log('Index: ' + mid);
        break;
    }
}



