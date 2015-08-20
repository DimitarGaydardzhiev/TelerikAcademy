//•Write a function that checks if a given object contains a given property.
//    var obj  = …;
//    var hasProp = hasProperty(obj, 'length');

var person = {
    firstName: 'Ivan',
    lastName: 'Ivanov',
    mark: 3,
    grade: 5,
    subject: 'JavaScript'
};

function hasProp(obj, property){
    if(typeof obj !== "object"){
        console.log('not an object type!');
    }

    for(var prop in obj){
        if(prop===property){
            return true;
            break;
        }
    }
    return false;
}

var hasProp = hasProp(person,'mark');

console.log(hasProp);


