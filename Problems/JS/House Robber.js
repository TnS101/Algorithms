var rob = function(nums) {
    let sum = 0;

    nums.reduce(function(acc, curr, i) {
        const element = nums[i];
        const next = nums[i + 1];

        if (next > element) {
            if (next + nums[i + 3] < nums[i + 2] + element) {
                sum += element + nums[i + 2];
                i += 3;
            } else {
                sum += next;
                i += 2;
            }
        } else {
            sum += element;
            i++;
        }
    }, 0);

    return sum;
};

console.log(rob(
    [2, 1, 1, 2]));
console.log(rob([2, 3, 2]));