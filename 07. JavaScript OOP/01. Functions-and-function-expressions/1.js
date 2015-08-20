/**
 * Created by dimit_000 on 17.6.2015 ã..
 */


function sum() {
    return function (numbers) {
        if (numbers.length === 0) {
            return null;
        }
        else if (numbers.some(isNaN)) {
            throw Error;
        }

        return numbers.reduce(function (result, number) {
            return result += +number;
        }, 0);
    }
}


console.log(sum([1, 2, 0]));
