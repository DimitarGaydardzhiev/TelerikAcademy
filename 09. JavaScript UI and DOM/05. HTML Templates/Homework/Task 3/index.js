function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = $(this);

            var strTmpl = $('#' + $this.attr('data-template')).html();

            var compiledTmpl = handlebars.compile(strTmpl);

            for (var i = 0; i < data.length; i++) {
                $this.append(compiledTmpl(data[i]));
            }

            return this;
        };
    };
}

module.exports = solve;