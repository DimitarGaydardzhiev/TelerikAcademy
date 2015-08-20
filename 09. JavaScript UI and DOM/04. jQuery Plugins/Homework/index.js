function solve() {
    return function (selector) {
        var $selectedList = $(selector)
            .css('display', 'none');

        var $container = $('<div>')
            .attr('class','dropdown-list')
            .append($selectedList);

        var options = $selectedList.find('option');
        
        //$container.addClass('dropdown-list');
        //$container.append($selectedList);
        console.log($('.dropdown-list').length);
        
        //$selectedList.css('display', 'none');

        var $current = $('<div>');
        $current.addClass('current')
                 .attr('data-value', '')
                 .html('Select value');

        var $optionsContainer = $('<div>');
        $optionsContainer.addClass('options-container')
        .css({
            'position': 'absolute',
            'display': 'none'
        });

        $(document).on('click','.current', function () {
            $optionsContainer.css('display', 'block');
        });

        $(document).on('click','.options-container', function (event) {
            var $this = $(event.target);

            $current.html($this.html());
            $optionsContainer.css('display', 'none');
        })

        for (var i = 0; i < options.length; i++) {
            var $divToAdd = $('<div>');

            $divToAdd.addClass('dropdown-item')
                     .attr('data-value', $(options[i]).attr('value'))
                     .attr('data-index', i)
                     .html($(options[i]).html());

            $divToAdd.appendTo($optionsContainer);
        }


        $current.appendTo($container);
        $optionsContainer.appendTo($container);
        $('body h1').after($container);
    };
}

module.exports = solve;