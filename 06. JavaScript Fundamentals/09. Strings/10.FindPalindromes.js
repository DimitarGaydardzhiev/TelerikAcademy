//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var i,
    len,
    result = [],
    input = 'some input text for example with a few palindromes -> ABBA, lamal, exe';

input = input.split((/[\s,]+/));

function extractPalindromes(text){
    for (i = 0, len = text.length; i < len; i += 1) {
        if((text[i]===text[i].split('').reverse().join(''))&&text[i].length>2){
            result.push(text[i]);
        }
    }
    return result;
}

console.log(extractPalindromes(input));