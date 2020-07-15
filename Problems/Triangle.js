var minimumTotal = function (triangle) {
    let sum = 0;
    for (let i = 0; i < triangle.length; i++) {
        const row = triangle[i];
        row.sort((a, b) => a - b);
        sum += row[0];
    }

    return sum;
};

console.log(minimumTotal([
    [-1],
    [2, 3],
    [1, -1, -3]
]));