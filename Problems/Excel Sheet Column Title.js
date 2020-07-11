var convertToTitle = function (n) {
    const alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];

    if (n > 26) {
        let result = '';
        const remainder = alphabet[n % 26 - 1];

        if (remainder != null) {
            result += alphabet[Math.floor(n / 26 - 1)];
            result += remainder;
        } else {
            result += alphabet[n / 26 - 2];
            result += alphabet[n / (n / 25)];
        }

        return result;
    }
    return alphabet[n - 1];
};

console.log(convertToTitle(52));
console.log(convertToTitle(703));