//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
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
];

function Person (firstName, lastName, age, gender){
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}

persons.every(function (item){
    console.log(item.age > 18);
});

