//Write a JavaScript function that replaces in a HTML document given as string all the tags  <a href="…">…</a>  with corresponding tags  [URL=…]…/URL] .
//
//input
//<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//
//output
//<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

var i,
    len,
    input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>';

function replaceTags(text){
    for (i = 0, len = text.length; i < len; i += 1) {
        text = text.replace('\"', '');
        text = text.replace('<a href','[URL');
        text = text.replace('</a>','[/URL]');
    }
    return text;
}

console.log(replaceTags(input));
