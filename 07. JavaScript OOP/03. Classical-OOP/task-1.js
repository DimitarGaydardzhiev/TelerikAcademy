/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {

    var Person = (function () {

        function checkIfNameIsAString(name) {
            return typeof name === "string";
        }

        function checkIfNameIsValidLength(name) {
            return (name.length >= 3 && name.length <= 20);
        }

        function checkLatinSymbols(name) {
            if (!(/[A-Za-z]/).test(name)) {
                throw new Error;
            }
        }

        function checkIfAgeIsValid(age) {
            if (age.toString() === '' || age != Number(age)) {
                throw new Error;
            }
            age = +age;

            if (age < 0 || age > 150) {
                throw new Error;
            }
        }

        function capitalize(string) {
            return string[0].toUpperCase() + string.slice(1);
        }

        function Person(firstname, lastname, age) {

            var _firstname, _lastname, _age;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function () {
                return this._firstname;
            },
            set: function (value) {
                if (!checkIfNameIsAString(value) || !checkIfNameIsValidLength(value)) {
                    throw new Error;
                }
                checkLatinSymbols(value);
                this._firstname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function () {
                return this._lastname;
            },
            set: function (value) {
                if (!checkIfNameIsAString(value) || !checkIfNameIsValidLength(value)) {
                    throw new Error;
                }
                checkLatinSymbols(value);
                this._lastname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function () {
                return this._age;
            },
            set: function (ageValue) {
                checkIfAgeIsValid(ageValue);
                this._age = ageValue;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function () {
                return (this.firstname + ' ' + this.lastname);
            },
            set: function (fullname) {
                var names = fullname.split(' '),
                    firstname = names[0].toLowerCase(),
                    lastname = names[1].toLowerCase();

                firstname = capitalize(firstname);
                lastname = capitalize(lastname);

                this.firstname = firstname;
                this.lastname = lastname;
            }
        });

        Person.prototype.introduce = function () {
            return 'Hello! My name is ' + this.firstname + ' ' + this.lastname +
                ' and I am ' + this.age + '-years-old';
        };

        return Person;
    }());
    return Person;
}
module.exports = solve;