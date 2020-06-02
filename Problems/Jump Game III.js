var canReach = function(array, start) {

    let zeroIndex = array.findIndex(function(num) { return num == 0 });

    for (let i = 0; i < array.length; i++) {
        let element = array[i];
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
    }
    return false;
};