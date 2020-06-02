var replaceElements = function(arr) {
    if (arr.length == 1) return [-1];

    let biggestElement = 0;
    let result = [];

    for (let index = 0; index < arr.length; index++) {
        if (arr[index] > biggestElement) {
            biggestElement = arr[index];
        }
    }

    let bigIndex = arr.findIndex(function(num) { return num == biggestElement });
    arr.splice(bigIndex, 1);

    for (let index = 0; index < arr.length; index++) {

        if (index < bigIndex) {
            result.push(biggestElement);
        } else {
            result.push(arr[index]);
        }
    }

    result.push(-1);

    return result;
};