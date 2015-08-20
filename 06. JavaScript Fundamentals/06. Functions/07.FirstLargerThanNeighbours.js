//Write a function that returns the index of the first element in array that is larger than its neighbours or  -1 , if there’s no such element.
//Use the function from the previous exercise.

var arr = [1,1,1,3,4,53,4,5,1,3,4,3,1,4,5,8];

function checkElement (array, index){

    if (index === undefined){
        var indexOfElement;
        for (var i = 1; i < array.length; i+=1) {
            if(array[i]>array[i-1]&&array[i]>array[i+1]){
                indexOfElement = i;
                break;
            }
            else{
                indexOfElement = -1;
            }
        }
        return indexOfElement;
    }
    else {
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
}

var result = checkElement(arr);
console.log(result);
