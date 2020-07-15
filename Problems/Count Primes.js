var countPrimes = function (n) {
    if (n <= 2) return 0;

    if (n <= 3) return 1;

    let count = 2;

    for (let i = 4; i < n; i++) {
        if (i % 2 != 0 && i % 3 != 0) {
            count++;
        }
    }

    return count;
};

console.log(countPrimes(10));