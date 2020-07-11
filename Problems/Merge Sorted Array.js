var merge = function (nums1, m, nums2, n) {
    nums1.splice(m, nums1.length);
    nums2.forEach(el => {
        nums1.push(el);
    });

    return nums1.sort((a, b) => a - b);
};

console.log(merge([1, 2, 3, 0, 0, 0], m = 3, [2, 5, 6], n = 3));