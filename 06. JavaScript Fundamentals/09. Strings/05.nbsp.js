//Write a function that replaces non breaking white-spaces in a text with  &nbsp ;

var i,
    len,
    text = 'Write a function that replaces non breaking white-spaces in a text with &nbsp';

function replaceNonBreakingWS (text){
    for (i = 0, len = text.length; i < len; i+=1) {
        text = text.replace(' ', '&nbsp');
    }
    return text;
}

console.log(replaceNonBreakingWS(text));