function solve(matrix) {
    let leftSum = 0;

    matrix.reduce(function(acc, curr, i) {
        let row = acc;
        if (row === undefined) row = matrix[i];

        for (let j = 0; j < row.length; j++) {
            leftSum += row[i];
            console.log(row[i]);
            leftSum -= row[row.length - i - 1];
            break;
        }
    });

    return Math.abs(leftSum);
}

console.log(solve([
    [11, 2, 4],
    [4, 5, 6],
    [10, 8, -12]
]));