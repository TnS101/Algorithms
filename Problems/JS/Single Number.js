var singleNumber = function (nums) {
    for (let i = 0; i < nums.length; i++) {
        const one = nums[i];
        const two = nums[i + 1]
        if (one != two) {
            nums.splice(i, 2);
        }

        if (nums.includes(one) === false) {
            return one;
        }

        if (nums.includes(two) === false) {
            return two;
        }
    }
};

console.log(singleNumber(

    [1, 3, 1, -1, 3]));