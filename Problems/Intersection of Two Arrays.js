var intersection = function(nums1, nums2) {
    let result = [];
    let map = new Map();

    nums1.reduce(function(acc, curr, i) {
        nums2.reduce(function(acc, curr, j) {
            if (nums1[i] == nums2[j]) {
                map.set(nums2[j], i);
            }
        }, 0);
    }, 0);

    for (const [key] of map) {
        result.push(key);
    }

    return result;
};

intersection(nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]);