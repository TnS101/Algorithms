var findNumbers = function(array) {
    let result = 0;

    for (let index = 0; index < array.length; index++) {
        if (String(array[index]).length % 2 == 0) {
            result++;
        }
    }
    return result;
};

findNumbers([12, 345, 2, 6, 7896]);