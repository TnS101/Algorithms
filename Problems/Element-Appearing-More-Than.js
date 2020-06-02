var findSpecialInteger = function(array) {
    let sum = 0;

    if (array.length == 1) {
        return array[0];
    }
    for (let i = 0; i < array.length; i++) {
        const element = array[i];
        if (array[i] == array[i + 1]) {
            sum++;
        } else {
            sum = 0;
        }
        if (sum >= 0.25 * array.length) {
            return element;
        }
    }
};