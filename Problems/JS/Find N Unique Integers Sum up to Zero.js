var sumZero = function(n) {
    let result = [];

    if (n == 1) return result[0];

    let counter = 1;

    for (let index = 0; index <= n; index += 2) {
        result.push(counter);
        result.push(counter * -1);
        counter++;
    }

    return result;
};