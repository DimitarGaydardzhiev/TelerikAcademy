var validator = {

    ValidateIfUndefined: function (value) {
        if (typeof (value) === 'undefined') {
            throw new Error;
        }
    },

    ValidateString: function (value) {
        if (typeof (value) != 'string') {
            throw new Error;
        }
    },

    ValidateElement: function (value) {
        this.ValidateIfUndefined(value);

        if ((value.tagName)) {
            throw new Error('Invalid element');
        }
    },

    ValidateContents: function (contents) {
        if (contents.some(function(item){
            return (typeof (item) !== 'string' && typeof (item) !== 'number');
        })) {
            throw new Error;
        }
    }
}

function task(element, contents) {
    var selectedElement,
        dFrag,
        newDiv,
        divToAdd,
        i,
        len

    function removeContent(node) {
        while (node.firstChild) {
            node.removeChild(node.firstChild);
            node.firstChild = node.nextSibling;
        }
    }

    validator.ValidateContents(contents);

    if (document.getElementById(element)) {
        selectedElement = document.getElementById(element);
        validator.ValidateIfUndefined(selectedElement);
    } else {
        selectedElement = element;
        validator.ValidateElement(element);
    }

    removeContent(selectedElement);

    dFrag = document.createDocumentFragment();

    newDiv = document.createElement('div');

    for (i = 0, len = contents.length; i < len; i++) {
        divToAdd = newDiv.cloneNode(true);
        divToAdd.innerHTML = contents[i];
        dFrag.appendChild(divToAdd);
    }

    selectedElement.appendChild(dFrag);
}
