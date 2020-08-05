var missingNumber = function (nums) {

    if (nums.length == 1) return nums[0] > 0 ? nums[0] - 1 : nums[0] + 1;

    if (nums.includes(0) === false) return 0;

    nums.sort((a, b) => a - b);

    for (let i = 0; i < nums.length; i++) {
        if (nums[i + 1] - nums[i] != 1) {
            return nums[i] + 1;
        }
    }
};

console.log(missingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]));