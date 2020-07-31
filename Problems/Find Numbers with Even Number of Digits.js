var findNumbers = function(array) {
    let result = 0;

    array.reduce(function(acc, curr) {
        if (String(curr).length % 2 == 0) {
            result++;
        }
    }, 0);

    return result;
};

console.log(findNumbers([12, 345, 2, 6, 7896]));