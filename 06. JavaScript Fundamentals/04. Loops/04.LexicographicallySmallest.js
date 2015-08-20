//Write a script that finds the lexicographically smallest and largest property in  document ,  window  and  navigator  objects.

function findSmallestProperty (objects){
    for (var object in objects) {
        var properties = [];

        for (var property in objects[object]){
            properties.push(property);
        }
            properties.sort();

        for (var i = 0; i < properties.length; i+=1) {
           console.log(properties[i]);
        }
}
}
console.log('Document: '/n)
findSmallestProperty([document]);
console.log('Window: ')
findSmallestProperty([window]);
console.log('Navigator: ')
findSmallestProperty([navigator]);