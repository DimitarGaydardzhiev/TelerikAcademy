//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//? Use Array#reduce
//? Use only array methods and no regular loops (for, while)
//
//    Example:
//        result = {
//            'a': [{
//                firstname: 'Asen',
//                /* ... */
//            }, {
//                firstname: 'Anakonda',
//                /* ... */
//            }],
//            'j': [{
//                firstname: 'John',
//                /* ... */
//            }]
//        };
//


var persons = [
        new Person('Pesho', 'Ivanov', 14, false),
        new Person('Gosho', 'Ivanov', 24, false),
        new Person('Gosho', 'Goshov', 12, false),
        new Person('Dragan', 'Ivanov', 54, false),
        new Person('Vasielena', 'Marinova', 11, true),
        new Person('Galia', 'Ivanova', 4, true),
        new Person('Vasilena', 'Georgieva', 65, true),
        new Person('Miro', 'Ivanov', 14, false),
        new Person('Miroslava', 'Pesheva', 25, true),
        new Person('Vasko', 'Vaskov', 46, false)
    ],
    result;

function Person(firstName, lastName, age, gender) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}

persons.sort(function (item1, item2) {
    return item1.firstName > item2.firstName;
});

result = persons.reduce(function (obj, item) {
    obj[item.firstName[0]] = [item];
    return obj;
}, {});

console.log(result);