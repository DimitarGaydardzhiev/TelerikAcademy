//Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype

String.prototype.format = function(options){
  var option,
      result = this;

    for (option in options){
        var regex = new RegExp('#{' + option + '}');
        result = result.replace(regex,options[option]);
    }
    return result;
};

var options = {name: 'John'};

console.log('Hello, there! Are you #{name}?'.format(options));

var options2 = {name: 'John', age: 13};
console.log(('My name is #{name} and I am #{age}-years-old').format(options2));