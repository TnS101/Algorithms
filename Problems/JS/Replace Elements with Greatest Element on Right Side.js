var replaceElements = function(arr) {
    if (arr.length == 1) return [-1];

    let biggestElement = 0;
    let result = [];

    arr.reduce(function(acc, curr) {
        if (curr > biggestElement) {
            biggestElement = curr;
        }
    }, 0);

    let bigIndex = arr.findIndex(function(num) { return num == biggestElement });
    arr.splice(bigIndex, 1);

    arr.reduce(function(acc, curr, index) {
        if (index < bigIndex) {
            result.push(biggestElement);
        } else {
            result.push(curr);
        }
    }, 0);

    result.push(-1);

    return result;
};