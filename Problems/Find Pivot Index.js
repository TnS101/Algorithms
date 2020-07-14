var pivotIndex = function (nums) {
    const outter = [0];
    for (let i = 0; i < nums.length; i++) {

        if (sum(outter) + nums[i] === sum(nums)) {
            return outter.length - 1;
        }

        outter.push(nums.shift(nums[i]));
        i--;
    }

    function sum(arr) {
        return arr.reduce(function (a, b) {
            return a + b;
        });
    }

    return -1;
};

console.log(pivotIndex([1, 7, 3, 6, 5, 6]));