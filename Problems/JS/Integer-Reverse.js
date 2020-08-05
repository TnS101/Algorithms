var reverse = function(x) {
    let result = x.toString();

    if (x < 0) {
        result = [result.slice(1, result.length), '-', result.slice(result.length)].join('');
    }

    if (result.endsWith('0')) {
        result = result.split('').slice(0, result.length - 1).join('');
    }

    let reverse = result.split('').reverse().join('');

    if (x >= 2147483648 || x <= -2147483648 || Number(reverse) >= 2147483648 || Number(reverse) <= -2147483648) return 0;

    return reverse;
};

reverse(-1563847412);