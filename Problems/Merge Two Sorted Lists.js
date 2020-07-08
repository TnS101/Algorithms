var mergeTwoLists = function (l1, l2) {
    const result = [];

    l1.forEach(el => {
        result.push(el);
    });

    l2.forEach(el => {
        result.push(el);
    });

    result.sort((a, b) => (a - b));

    return result;
};

console.log(mergeTwoLists([1, 2, 3], [1, 4, 5]));