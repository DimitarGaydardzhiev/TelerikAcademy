//• Write a function that makes a deep copy of an object.
//• The function should work for both primitive and reference types.

function deepCopy (obj){
    if (typeof obj !== "object"){
        return obj;
    }

    var copied = {};

    for(var prop in obj){
        copied[prop]=deepCopy(obj[prop]);
    }

    return copied;
}

console.log(deepCopy(3));

var person = {
    firstName: 'Ivan',
    lastName: 'Ivanov'
};

console.log(deepCopy(person));
