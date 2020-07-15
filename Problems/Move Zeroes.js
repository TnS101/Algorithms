var moveZeroes = function (nums) {
    let counter = 0;

    for (let i = 0; i < nums.length; i++) {
        if (nums[i] == 0) {
            nums.splice(i, 1);
            counter++;
            i--;
        }
    }
    for (let i = 0; i < counter; i++) {
        nums.push(0);
    }

    return nums;
};

console.log(moveZeroes([0, 0, 1]));