var firstMissingPositive = function(nums) {
    if (nums.length == 0) return 1;
    nums.sort((a, b) => a - b);
    nums.reduce(function(acc, curr, i) {
        if (nums[i] + 1 != nums[i + 1] && nums[i + 1] != undefined) {

            if (nums[0] < 0) return nums[i + 1] + 1 < nums[0] ? 1 : nums[i + 1] + 1;

            return nums[i + 1] + 1 > nums[0] ? 1 : nums[0] - 1;
        }
        if (i == nums.length - 1) {
            if (nums[0] < 0) return nums[i] + 1 < nums[0] ? 1 : nums[i] + 1;
            return nums[i] + 1 > nums[0] ? 1 : nums[i] - 1;;
        }
    }, 0);
};
console.log(firstMissingPositive([2]));
console.log(firstMissingPositive([7, 8, 9, 11, 12]));