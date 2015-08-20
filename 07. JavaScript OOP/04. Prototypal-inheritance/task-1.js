
function solve() {
    var domElement = (function () {

        //validate data
        function validateDomElementType(type) {
            if(typeof type !== 'string' || type === '' || !(/^[A-Za-z0-9]+$/i.test(type))){
                throw new Error;
            }
        }
        function validateAttributes(attribute) {
            if (typeof attribute !== 'string' || attribute === '' || !(/^[A-Za-z\d\-]+$/i.test(attribute))) {
                throw new Error;
            }
        }

        var domElement = {
            //defining properties
            get parent() {
                return this._parent;
            },
            set parent(value) {
                this._parent = value;
            },
            get children() {
                return this._children;
            },
            set children(value) {
                this._children = value;
            },
            get type() {
                return this._type;
            },
            set type(value) {
                this._type = value;
            },
            get content() {
                return this._content;
            },
            set content(value) {
                this._content=valie;
            },
            get attributes() {
                return this._attributes;
            },
            set attributes(value) {
                this._attributes = value;
            },

            init: function (type) {
                validateDomElementType(type);

                this.type = type;
                this.innerHTML;
                this.content;
                this.attributes = {};
                this.children = [];
                this.parent;
                return this;
            },
            appendChild: function (child) {
                this.children.push(child);
                return this;
            },
            addAttribute: function (name, value) {
                validateAttributes(name);

                this.attributes[name] = value;
                return this;
            },
            removeAttribute: function (attribute) {
                if (!(this.attributes[attribute])) {
                    throw new Error;
                }

                delete this.attributes[attribute];
                return this;
            },
            get innerHTML() {

            }
        };
        return domElement;
    }());

    return domElement;
}

module.exports = solve;
