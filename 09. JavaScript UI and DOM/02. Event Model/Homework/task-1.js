function solve() {
    return function (selector) {
        var element,
            buttons,
            contents,
            i,
            len,
            event,
            currentContent;

        if (typeof selector === 'undefined') {
            throw new Error;
        }

        function isHidden(el) {
            if (el.style.display === 'none') {
                return true;
            }
            return false;
        }

        if (document.getElementById(selector)) {
            element = document.getElementById(selector);
        } else if(selector instanceof HTMLElement){
            element = selector;
        } else {
            throw new Error;
        }

        buttons = document.querySelectorAll('.button');
        contents = document.querySelectorAll('.content');

        for (i = 0, len = contents.length; i < len; i += 1) {
            contents[i].setAttribute('style.display', '');
        }

        for (i = 0, len = buttons.length; i < len; i += 1) {
            buttons[i].innerHTML = 'hide';
        }

        for (i = 0, len = buttons.length; i < len; i += 1) {

                buttons[i].addEventListener('click', function () {
                    currentContent = this.nextElementSibling;

                    while (currentContent.className !=='button') {
                        if (currentContent.className === 'content') {
                            break;
                        }
                        currentContent = currentContent.nextElementSibling;
                    }
                   
                    if (currentContent.className ==='content' && isHidden(currentContent)) {
                        currentContent.style.display = '';
                        this.innerHTML = 'hide';
                    } else if (currentContent.className === 'content' && !isHidden(currentContent)) {
                        currentContent.style.display = 'none';
                        this.innerHTML = 'show';
                    }
                }, false);
        }
    };
};

module.exports = solve;