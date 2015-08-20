//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var number = 996;

var digits = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
var special = ['eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];
var round = ['ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety', 'hundred'];

for (var i = 0; i < 10; i+=1) {
    if (number>=0&&number<10){
        console.log(digits[number]);
    }
    if (number>10&&number<20){
        console.log(special[number%10-1]);
    }
    if (number%10 === 0){
        console.log(round[(number/10)-1]);
    }
    if (number>100&&number<=999){
        var result = parseFloat((number/100) | 0);
        if (number%100 === 0){
            console.log(digits[result] + ' ' + round[9]);
        }
        else{
            var secondResult = number % 100;
            if (secondResult>=1&&secondResult<10){
                console.log(digits[result] + ' ' + round[9] + ' ' + 'and' + ' ' + digits[secondResult]);
            }
            if (secondResult%10===0){
                console.log(digits[result] + ' ' + round[9] + ' ' + 'and' + ' ' + round[(secondResult/10)-1]);
            }
            else {
                console.log(digits[result] + ' ' + round[9] + ' ' + 'and' + ' ' + round[((secondResult/10) - 1) | 0] + ' ' + digits[secondResult%10]);
            }

        }
    }
}
