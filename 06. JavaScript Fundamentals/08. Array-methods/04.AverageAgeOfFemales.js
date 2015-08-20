//Write a function that calculates the average age of all females, extracted from an array of persons
//? Use Array#filter
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
    result=[];

function Person (firstName, lastName, age, gender){
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}

result = persons.filter(function(item){
    if(item.gender){
        return Person;
    }
});

console.log('Females: ');
result.forEach(function(item){
    console.log(item.firstName + ' ' + item.lastName + ' ' + item.age);
});



