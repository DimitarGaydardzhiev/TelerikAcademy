//Write a function to count the number of  div  elements on the web page.



function countDivs (){
    var divs = document.getElementsByTagName('div').length;
    return divs;
}

console.log(countDivs());