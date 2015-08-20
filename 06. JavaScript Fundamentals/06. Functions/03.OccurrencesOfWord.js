//• Write a function that finds all the occurrences of word in a text.
//• The search can be case sensitive or case insensitive.
//• Use function overloading.

var text = 'Write a Function that finds all the occurrences of word in a text. The search can be case sensitive or case insensitive. Use function overloading.';
var word = 'function';

function countOccurrencesOfWord (text, word, isCaseSensitive){
    isCaseSensitive = isCaseSensitive || false;
    if(isCaseSensitive===true){
        var a = text.toLowerCase();
    }
    else{
        a = text;
    }
    var sub = a.split(word);
    return sub.length-1;
}

console.log(countOccurrencesOfWord(text,word,true));

