var twoSum = function(nums, target) {
    let map = new Map;

    for (let index = 0; index < nums.length; index++) {
        let complement = target - nums[index];
        if (map.has(complement) && map.get(complement) != index) {
            return [map.get(complement), index];
        }
        map.set(nums[index], index);
    }
};

twoSum([2, 7, 11, 15],
    9);