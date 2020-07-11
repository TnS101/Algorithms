var majorityElement = function (nums) {

    if (nums.length == 1) return nums[0];

    for (let i = 0; i < nums.length; i++) {
        if (nums.filter(n => n == nums[i]).length > nums.length / 2) {
            return nums[i];
        }
    }
};

console.log(majorityElement([6, 5, 5]));
console.log(majorityElement([8, 8, 7, 7, 7]));