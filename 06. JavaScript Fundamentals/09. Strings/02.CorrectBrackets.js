//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//
//    Example of correct expression:  ((a+b)/5-d) . Example of incorrect expression:  )(a+b)) .

var i,
    len,
    exp = '((a+b)/5-d)',
    openingCounter = 0,
    closingCounter = 0;

for (i = 0, len = exp.length; i < exp.length; i+=1) {
    if (exp[i]==='('){
        openingCounter+=1;
    }
    if (exp[i]===')'){
        closingCounter+=1;
    }
}

if(openingCounter===closingCounter){
    console.log('The expression is correct!')
}
else{
    console.log('The expression is incorrect!')
}