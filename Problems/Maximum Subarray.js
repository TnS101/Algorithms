var maxSubArray = function (nums) {
    nums = nums.filter(n => n > 0);
    return nums.reduce(function (a, b) {
        return a + b;
    });
};

console.log(maxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]));