//Write a script that compares two char arrays lexicographically (letter by letter).

var i,
    len,
    biggerLen,
    biggerArr = [];
    firstArr = ['a','g','b','h','y','s','h','j'],
    secondArr = ['b','g','o','l','q','d','r','f'];

for (i = 0, len = firstArr.length; i < len; i+=1) {
    if (firstArr[i]<=secondArr[i]){
        biggerArr[i]=firstArr[i];
    }
    else{
        biggerArr[i]=secondArr[i];
    }
}
console.log(biggerArr.join(', '));


