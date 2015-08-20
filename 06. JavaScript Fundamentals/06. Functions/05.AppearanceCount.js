//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

var arr = [1,1,1,3,4,53,4,5,1,3,4,3,1,4,5,8];
var number = 1;

function countNumberInArray (array, number){
    var i,
        len,
        counter = 0;
    for (i=0, len=array.length; i<len; i+=1) {
        if(array[i]===number){
            counter+=1;
        }
    }
    return counter;
}

var result = countNumberInArray(arr,number);
console.log(result);

function testCount (count){
        if (arr.indexOf(number)>-1&&count>=0){
            console.log('correct!')
        }
        else if (arr.indexOf(number)===-1&&count===0){
            console.log('correct');
        }
        else if (arr.indexOf(number)>-1&&count<0){
            console.log('incorrect');
        }
        else if (arr.indexOf(number)===-1&&count>=1){
            console.log('incorrect');
        }
}

testCount(countNumberInArray(arr,number));