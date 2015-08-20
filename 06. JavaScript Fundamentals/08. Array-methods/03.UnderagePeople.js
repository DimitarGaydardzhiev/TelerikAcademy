//Write a function that prints all underaged persons of an array of person
//? Use Array#filter and Array#forEach
//? Use only array methods and no regular loops (for, while)

var persons = [
    new Person('Pesho','Ivanov',14,false),
    new Person('Ivan','Ivanov',24,false),
    new Person('Gosho','Goshov',12,false),
    new Person('Dragan','Ivanov',54,false),
    new Person('Maria','Marinova',11,true),
    new Person('Galia','Ivanova',4,true),
    new Person('Vasilena','Georgieva',65,true),
    new Person('Miro','Ivanov',14,false),
    new Person('Miroslava','Pesheva',25,true),
    new Person('Vasko','Vaskov',46,false)
    ],
    result = [];

function Person (firstName, lastName, age, gender){
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}

result = persons.filter(function(item){
    return item.age<20;
});

console.log('People under 20 years old:');
result.forEach(function(item){
    console.log(item.firstName+' '+item.lastName+' '+item.age)
});


