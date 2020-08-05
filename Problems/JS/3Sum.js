var threeSum = function (nums) {
    let result = [];
    let set = [];
    let counter = 0;
    while (true) {
        set.push(nums[counter]);

        if (set.length == 3) {
            if (set.reduce(function (a, b) {
                    return a + b;
                }) == 0 && result.find(s => s.id == counter) === undefined) {
                result.push({
                    id: `${counter}`,
                    set: set
                });
                counter = -1;
            }
            set = [];
        }

        if (result.length >= 1) {
            return result;
        }

        counter++;
    }
};

console.log(threeSum([-1, 0, 1, 2, -1, -4]));