var sequentialDigits = function(low, high) {
    let number = '';
    let result = [];
    let min = String(low);

    let counter = 0;
    while (true) {
        if (Number(number) >= low && Number(number) < high) {
            result.push(Number(number));
            number = '';
            counter -= min.length - 1;
        }

        if (Number(number) >= high) {
            console.log(result);
            return result;
        }

        number += Number(min[0]) + counter;
        counter++;
    }
};

sequentialDigits(low = 1000, high = 13000);