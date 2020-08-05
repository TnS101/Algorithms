var removeDuplicates = function (nums) {
    for (let i = 0; i < nums.length; i++) {
        if (nums.filter(n => n == nums[i]).length > 1) {
            nums.splice(i, 1);
            i = -1;
        }
    }

    return nums;
};

console.log(removeDuplicates([1, 1, 2]));