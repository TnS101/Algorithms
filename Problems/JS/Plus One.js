var plusOne = function (digits) {
    for (let i = digits.length - 1; i >= 0; i--) {
        let element = digits[i];
        if (element + 1 == 10) {
            if (digits[i - 1] === undefined) {
                digits.push(1);
                digits[i] = 0;
                return digits.reverse();
            }
            digits[i] = 0;

        } else {
            digits[i] += 1;
            break;
        }
    }

    return digits;
};

console.log(plusOne([3, 9, 9]));