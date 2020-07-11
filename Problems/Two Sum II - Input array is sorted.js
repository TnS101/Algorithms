var twoSum = function (numbers, target) {
    for (let i = 0; i < numbers.length; i++) {
        if (numbers[i] <= target) {
            for (let j = i + 1; j < numbers.length; j++) {
                if (numbers[i] + numbers[j] == target) {
                    return [i + 1, j + 1];
                }

            }
        }
    }
};

console.log(twoSum([0, 0, 3, 4], 0));
console.log(twoSum([2, 7, 11, 15], target = 9));