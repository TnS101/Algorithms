var intersection = function(nums1, nums2) {
    let result = [];
    let map = new Map();

    for (let i = 0; i < nums1.length; i++) {
        for (let j = 0; j < nums2.length; j++) {
            if (nums1[i] == nums2[j]) {
                map.set(nums2[j], i);
            }
        }
    }

    for (const [key] of map) {
        result.push(key);
    }

    return result;
};

intersection(nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]);