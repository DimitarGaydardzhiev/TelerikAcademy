//Write a function that returns the last digit of given integer as an English word.

var number = 5643;

function returnLastDigit (N){
    N+='';
    var i,
        len = N.length;
        arr = [];

    for (i=0; i<len; i+=1) {
        arr.push(N[i]);
    }
    arr.reverse();
    switch (arr[0]){
        case '0':
            console.log('zero');
            break;
        case '1':
            console.log('one');
            break;
        case '2':
            console.log('two');
            break;
        case '3':
            console.log('three');
            break;
        case '4':
            console.log('four');
            break;
        case '5':
            console.log('five');
            break;
        case '6':
            console.log('six');
            break;
        case '7':
            console.log('seven');
            break;
        case '8':
            console.log('eight');
            break;
        case '9':
            console.log('nine');
            break;
        default:
            console.log('not a number');
            break;
    }
}

returnLastDigit(number);