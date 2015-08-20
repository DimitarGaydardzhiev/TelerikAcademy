//Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.
//
//    Examples:
//  var str = stringFormat('Hello {0}!', 'Peter');
//  //str = 'Hello Peter!';
//
//  var frmt = '{0}, {1}, {0} text {2}';
//  var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
//  //str = '1, Pesho, 1 text Gosho'
//

var i,
    len;

function formatString(text){
    for (i = 0, len = text.length; i < len; i += 1) {
        var rexExp = new RegExp('[{]' + i + '[}]', 'g');
        text = text.replace(rexExp,arguments[i+1]);
    }
    return text;
}

var format = '{0}, {1}, {0} text {2}';
var str = formatString(format, '1', 'Pesho', 'Gosho');
console.log(str);