//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.
//
//Example:
// var people = [
//    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
//    { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];

 var people = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname : 'Bay', lastname: 'Ivan', age: 81},
     { firstname : 'Gosho', lastname: 'Goshov', age: 11},
     { firstname : 'Mitko', lastname: 'Ivanov', age: 23},
     { firstname : 'Bay', lastname: 'Dragan', age: 101}
 ];

function findYoungest(arr){
    var youngest = 1/0; //+infinity
    var result;
    for (var i = 0; i < arr.length; i+=1) {
        if(arr[i].age<youngest){
            youngest=arr[i].age;
            result = arr[i];
        }
    }
    console.log('The youngest person is: ' + result.firstname + ' ' + result.lastname + ' ' + 'age: ' + result.age);
}

console.log(findYoungest(people));
