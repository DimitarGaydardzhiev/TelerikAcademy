function findPrimes() {
    return function (from, to) {
        var i,
            primes = [];

        function isPrime(number) {
            var start = 2;
            while (start <= Math.sqrt(number)) {
                if (number % start < 1) return false;
                start += 1;
            }
            return number > 1;
        }

        if (arguments.length <= 1) {
            throw new Error;
        }
        else {
            for (i = +from; i <= +to; i += 1) {
                if (isPrime(i)) {
                    primes.push(i);
                }
            }
            return primes;
        }
    }
}