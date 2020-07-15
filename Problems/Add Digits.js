var addDigits = function (num) {
    while (true) {
        if (num < 10) {
            return num;
        }

        num = num.toString().split('').reduce(function (a, b) {
            return Number(a) + Number(b);
        });
    }
};

console.log(addDigits(38));