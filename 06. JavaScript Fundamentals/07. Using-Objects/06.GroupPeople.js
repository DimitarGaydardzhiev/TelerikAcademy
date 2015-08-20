//• Write a function that groups an array of people by age, first or last name.
//• The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//
//•Use function overloading (i.e. just one function)
//
//Example:
//
//    var people = {…};
//    var groupedByFname = group(people, 'firstname');
//    var groupedByAge= group(people, 'age');

var persons = [
    new Person('Gosho', 32),
    new Person('Ivan', 15),
    new Person('Dragan', 55),
    new Person('Mitko', 105),
    new Person('Kaloian', 18),
    new Person('Pesho', 32)
];


function Person(name, age) {
    this.name = name,
    this.age = age
}

function group(persons, property) {
    var group = {},
        key;

    persons.forEach(function (person) {
        key = person[property];
        group[key] = group[key] || [];
        group[key].push(person);
    });
    return group;
}

var groupByAge = group(persons,'age');
var groupByName = group(persons,'name');

console.log(groupByAge);
console.log(groupByName);
