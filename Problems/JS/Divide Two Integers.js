var divide = function (dividend, divisor) {
    const result = dividend / divisor;

    if (result < -2147483648) return (-2147483648 + 1);
    if (result >= 2147483648) return (2147483648 - 1);
    return result < 0 ? Math.ceil(result) : Math.floor(result);
};

console.log(divide(
    -2147483648, -1));