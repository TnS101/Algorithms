var findSpecialInteger = function(array) {
    let sum = 0;

    if (array.length == 1) {
        return array[0];
    }
    array.reduce(function(pr, curr, i) {
        if (array[i - 1] == curr) {
            sum++;
        } else {
            sum = 0;
        }
        if (sum >= 0.25 * array.length) {
            return curr;
        }
    }, 0);
};

console.log(findSpecialInteger([1, 2, 3, 3, 5, 6]));