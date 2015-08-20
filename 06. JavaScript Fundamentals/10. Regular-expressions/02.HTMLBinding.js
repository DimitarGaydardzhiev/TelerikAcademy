//Write a function that puts the value of an object into the content/attributes of HTML tags.
// Add the function to the String.prototype

String.prototype.bind = function(objects) {
    var regex,
        object,
        result = this;

    for (object in objects){
        var regexContent = new RegExp('(<.+content="'+object+'".+>)(<\/.+>)');
        var regexHref = new RegExp('data-bind-href="'+object+'"');
        var regexClass = new RegExp('data-bind-class="'+object+'"');

        result = result.replace(regexContent,function(match, openingTag, content, closingTag) {
                        return openingTag + objects[object] + closingTag;
                    });
        //result = result.replace(regexHref,objects[object]);
        //result = result.replace(regexClass,objects[object]);
    }
    return result;
};


console.log('<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>'.bind({name: 'Elena', link: 'http://telerikacademy.com'}));

