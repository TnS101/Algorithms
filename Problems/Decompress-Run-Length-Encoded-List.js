var decompressRLElist = function(array) {
    let result = [];

    array.reduce(function(acc, curr, index) {
        if (index % 2 == 0) {
            for (let i = 0; i < curr; i++) {
                result.push(array[index + 1]);
            }
        }
    });

    return result;
};

decompressRLElist([1, 1]);