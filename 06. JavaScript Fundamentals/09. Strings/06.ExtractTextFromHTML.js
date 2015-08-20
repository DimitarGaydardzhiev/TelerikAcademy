//Write a function that extracts the content of a html page given as text.
//The function should return anything that is in a tag, without the tags.
//
//    Example:
//<html>
//<head>
//<title>Sample site</title>
//</head>
//<body>
//<div>text
//<div>more text</div>
//and more...
//</div>
//in body
//</body>
//</html>
//
//
//Result: Sample sitetextmore textand more...in body

var i,
    len,
    htmlText = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more... </div>in body </body></html>';

for (i = 0, len = htmlText.length; i < len; i+=1) {
    var startIndex = htmlText.indexOf('<');
    var endIndex = htmlText.indexOf('>');
    var tagText = htmlText.substring(startIndex,endIndex+1);
    htmlText = htmlText.replace(tagText, '');
}

console.log(htmlText);
