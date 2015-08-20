//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
//
//Example:
//
//    The target sub-string is  in
//
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.
// So we are drinking all the day. We will move out of it in 5 days.
//
//The result is:  9


var i,
    len,
    text = 'We are livig in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
    counter = 0;


for (i = 0, len = text.length; i < text.length; i++) {
    if (text[i].toLowerCase() === 'i' && text[i + 1].toLowerCase() === 'n') {
        counter += 1;
    }
}

console.log(counter);