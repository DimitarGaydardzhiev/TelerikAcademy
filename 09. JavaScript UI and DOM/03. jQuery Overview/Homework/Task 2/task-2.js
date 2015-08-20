/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function (selector) {

        if ($(selector).size() === 0 || typeof (selector) !== 'string') {
            throw new Error;
        }

        var $buttons = $(selector).find('.button').html('hide'),
            $contents = $(selector).find('.content');

        $buttons.on('click', function (ev) {
            var $current = $(ev.target);

            while ($current) {
                if ($current.hasClass('content')) {
                    break;
                }
                $current = $current.next();
            }
            if ($current.css('display') === 'none') {
                $(ev.target).html('hide');
                $current.css('display', '');
            } else {
                $(ev.target).html('show');
                $current.css('display', 'none');
            }
        });
    };
};

module.exports = solve;