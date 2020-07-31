function solve(matrix) {
    let leftSum = 0;

    matrix.reduce(function(acc, curr, i) {
        for (let j = 0; j < curr.length; j++) {
            leftSum += curr[i];
            console.log(curr[i]);
            leftSum -= curr[curr.length - i - 1];
            break;
        }
    }, 0);

    return Math.abs(leftSum);
}

console.log(solve([
    [11, 2, 4],
    [4, 5, 6],
    [10, 8, -12]
]));