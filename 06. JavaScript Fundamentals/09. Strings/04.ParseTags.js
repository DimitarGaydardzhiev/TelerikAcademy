//•You are given a text. Write a function that changes the text in all regions:
//    <upcase>text</upcase> to uppercase.
//    <lowcase>text</lowcase> to lowercase
//    <mixcase>text</mixcase> to mix casing(random)
//
//
//Example: We are  <mixcase>living</mixcase>  in a  <upcase>yellow submarine</upcase> . We  <mixcase>don't</mixcase>  have  <lowcase>anything</lowcase>  else.
//
//The expected result:
//    We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
//
//Note: Regions can be nested.

var i,
    len,
    startIndex,
    endIndex,
    endIndexBtwTags,
    tagName,
    wholeOpenTag,
    wholeCloseTag,
    textInTags,
    str,
    letter,
text = 'We are  <mixcase>living</mixcase>  in a  <upcase>yellow submarine</upcase> . We  <mixcase>don\'t</mixcase>  have <lowcase>anything</lowcase>  else.';

result = text.split(' ');

for (i = 0, len = result.length; i < len; i += 1) {
    startIndex = text.indexOf('>');
    endIndex = text.indexOf('<');
    endIndexBtwTags = text.indexOf('</');
    tagName = text.substring(startIndex,endIndex+1); //?
    wholeOpenTag = text.substring(endIndex,startIndex+1);
    wholeCloseTag = text.substring(endIndexBtwTags,startIndex+1);
    textInTags = text.substring(startIndex+1,endIndexBtwTags);
    str = '';

    if(tagName === 'mixcase'){
        for (var j = 0; j < textInTags.length; j+=1) {
            letter = textInTags.charAt(j);
            if(!(j%2)){
                letter = letter.toUpperCase();
            }
            str+=letter;
        }
    }
    else if(tagName === 'upcase'){
        str = textInTags.toUpperCase();
    }
    else if(tagName === 'lowcase'){
        str = textInTags.toLowerCase();
    }

    text = text.replace(textInTags,str);
    text = text.replace(wholeOpenTag, '');
    startIndex = 0;
    endIndex = 0;
    endIndexBtwTags = 0;
}
console.log(text);