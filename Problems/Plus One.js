var plusOne = function (digits) {
    let willIncrement = false;
    for (let i = digits.length - 1; i >= 0; i--) {
        let element = digits[i];
        if (element + 1 == 10 || element == 0 && willIncrement == true) {
            if (digits[i - 1] === undefined) {
                digits.push(1);
                digits[i] = 0;
                return digits.reverse();
            }
            willIncrement = true;
            digits[i] = 0;

        } else {
            digits[i] += 1;
            break;
        }
    }

    return digits;
};

console.log(plusOne([9]));