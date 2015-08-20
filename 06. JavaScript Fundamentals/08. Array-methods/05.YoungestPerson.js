//Write a function that finds the youngest male person in a given array of people and prints his full name
//? Use only array methods and no regular loops (for, while)
//? Use Array#find

var persons = [
        new Person('Pesho', 'Ivanov', 14, false),
        new Person('Ivan', 'Ivanov', 24, false),
        new Person('Gosho', 'Goshov', 12, false),
        new Person('Dragan', 'Ivanov', 54, false),
        new Person('Maria', 'Marinova', 11, true),
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

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i,
            len = this.length;

        for(i=0;i<len;i+=1){
            if(callback(this[i],i,this)){
                return this[i];
            }
        }
    }
}

persons.sort(function (first, second) {
    return first.age - second.age;
});

result = persons.find(function (item) {
    return item.firstName;
});

console.log(result.firstName + ' ' + result.lastName + ' ' + result.age);

