//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

var arr = [1,1,1,3,4,53,4,5,1,3,4,3,1,4,5,8];

function checkElement (array, index){
    if(index>0&&index<array.length){
        if(array[index]>array[index-1]&&array[index]>array[index+1]){
            return true;
        }
        else{
            return false;
        }
    }
    else{
        console.log('No left or right neighbour of the element exist!');
    }
}

var result = checkElement(arr,5);
console.log(result);