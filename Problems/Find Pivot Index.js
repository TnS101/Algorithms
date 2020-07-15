var pivotIndex = function (nums) {
    let sum = 0;
    for (let i = 0; i < nums.length; i++) {
        const element = nums[i];
        if (sum + element ==
            nums.reduce(function (a, b) {
                return a + b;
            }) - sum) {
            return i;
        }

        sum += element;
    }
    return -1;
};

console.log(pivotIndex([1, 7, 3, 6, 5, 6]));