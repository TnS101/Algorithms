function solve(matrix) {
    let leftSum = 0;
    for (let i = 0; i < matrix.length; i++) {
        const row = matrix[i];
        for (let j = 0; j < row.length; j++) {
            leftSum += row[i];
            leftSum -= row[row.length - 1 - i];
            break;
        }
    }

    return Math.abs(leftSum);
}

console.log(solve([
    [11, 2, 4],
    [4, 5, 6],
    [10, 8, -12]
]));