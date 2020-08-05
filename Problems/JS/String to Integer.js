var myAtoi = function (str) {
    const regex = new RegExp('[^+-][^-+]* *-*\\+*[0-9]+');
    if (regex.test(str.split(' ')) === false) return 0;

    const testRegex = new RegExp(' *-*\\+*[0-9]+');

    const output = Number(testRegex.exec(str.split(' ')));

    if (output > 2147483648) return 2147483648;
    if (output < -2147483648) return -2147483648;
    return output;
};

console.log(myAtoi(
    "words and 987"
));