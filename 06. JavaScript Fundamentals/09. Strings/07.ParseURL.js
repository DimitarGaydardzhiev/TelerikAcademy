//Write a script that parses an URL address given in the format:  [protocol]://[server]/[resource]  and extracts from it the  [protocol] ,  [server]  and  [resource]  elements.
//Return the elements in a JSON object.
//
//    Example:
//
//URL
//http://telerikacademy.com/Courses/Courses/Details/239
//result
//
//  { protocol:  http ,
//    server:  telerikacademy.com
//resource:  /Courses/Courses/Details/239

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

for (var i = 0; i < url.length; i++) {
    var protStartIndex = url.indexOf('h');
    var protEndIndex = url.indexOf('p');
    var servStartIndex = url.indexOf('//');
    var servEndIndex = url.indexOf('.com');
    var resStartIndex = url.indexOf('.com');

    var prot = url.substring(protStartIndex,protEndIndex+1);
    var serv = url.substring(servStartIndex+2,servEndIndex+4);
    var res = url.substring(resStartIndex+4,url.length);

}
var result = {
    protocol: prot,
    server: serv,
    resource: res
};

console.log(result);

