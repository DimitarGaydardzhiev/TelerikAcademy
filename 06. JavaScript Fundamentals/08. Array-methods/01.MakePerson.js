//• Write a function for creating persons.
//? Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders

var persons = [
    new Person('Pesho','Ivanov',24,false),
    new Person('Ivan','Ivanov',24,false),
    new Person('Gosho','Goshov',24,false),
    new Person('Dragan','Ivanov',24,false),
    new Person('Maria','Marinova',24,true),
    new Person('Galia','Ivanova',24,true),
    new Person('Vasilena','Georgieva',24,true),
    new Person('Miro','Ivanov',24,false),
    new Person('Miroslava','Pesheva',24,true),
    new Person('Vasko','Vaskov',24,false)
];

function Person (firstName, lastName, age, gender){
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}

persons.forEach(function (item,index){
    index+=1;
    console.log(index + ' ' + item.firstName + ' ' + item.lastName);
});
