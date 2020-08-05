var canReach = function(array, start) {
    let zeroIndex = array.findIndex(function(num) { return num == 0 });

    array.reduce(function(acc, element, i) {
        if (start > zeroIndex) {
            if (i - element >= 0) {
                start = i - array[start];
            }
        } else {
            if (i + element < array.length) {
                start = i + array[start];
            }
        }

        if (start == zeroIndex) {
            return true;
        }
    }, 0);

    return false;
};