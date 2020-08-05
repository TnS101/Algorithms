var searchInsert = function (nums, target) {

    if (nums.includes(target) === false) {
        nums.push(target);
        nums.sort((a, b) => a - b);
    }

    return nums.findIndex(v => v == target);
};
console.log(searchInsert(
    [1, 3, 4, 6, 7, 10], 11));

console.log(searchInsert(
    [1, 3, 5, 6], 2));