var decompressRLElist = function(array) {
    let result = [];

    for (let index = 0; index < array.length; index++) {
        if (index % 2 == 0) {
            for (let i = 0; i < array[index]; i++) {
                result.push(array[index + 1]);
            }
        }
    }

    return result;
};

decompressRLElist([1, 1]);