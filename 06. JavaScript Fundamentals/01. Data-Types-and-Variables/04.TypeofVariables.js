/**
 * Try typeof on all variables you created.
 */

//Array literal

var arr = [];
arr = ['blue','red','green'];

//Integer literal

var number = 5;

//Floating number literals

var floatNumber = 1.42;

//Boolean literals

var firstNumber = 1;
var secondNumber = 2;

var isFirstGreater = (firstNumber > secondNumber);
console.log(isFirstGreater); //false

var isSecondGreater = (firstNumber < secondNumber);
console.log(isSecondGreater); //true

//Object literals

var someObject = {}; //Object without properties

var student = {
    firstName: 'Misho',
    lastName: 'Mishov',
    groupNumber: 5
};

//String literals

var someString = 'Samo' + ' ' + 'Levski';


//TypeOf

console.log(typeof(arr));
console.log(typeof(number));
console.log(typeof(floatNumber));
console.log(typeof(isFirstGreater));
console.log(typeof(isSecondGreater));
console.log(typeof(someObject));
console.log(typeof(student));
console.log(typeof(someString));
