//Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.

var i,
    len,
    result = [],
    text = 'first email: somemail@yahoo.com, second email: fname_lname@gmail.com, third email: myname@abv.bg';

text = text.split(' ');

function extractEMails(text) {
    for (i = 0, len = text.length; i < len; i += 1) {

        if(text[i].indexOf('@')!==-1){
            text[i] = text[i];
            result.push(text[i]);
        }
    }
    return result;
}

console.log(extractEMails(text));