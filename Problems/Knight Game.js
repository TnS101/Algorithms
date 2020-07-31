function solution(matrix) {
    let sum = 0;
    let count = 0;
    matrix.reduce(function(acc, row, i) {
        let currentSum = 0;
        row.reduce(function(acc, curr, j) {
            if (curr == 'K') {

                if (matrix[i + 2] !== undefined && matrix[i - 2] !== undefined) {
                    if (matrix[i + 2][j - 1] === 'K') currentSum++; //left L
                    if (matrix[i + 2][j + 1] === 'K') currentSum++; //normal L
                    if (matrix[i - 2][j - 1] === 'K') currentSum++; //left upper L
                    if (matrix[i - 2][j + 1] === 'K') currentSum++; //right upper L

                    if (currentSum > sum) {
                        count++;
                        sum = currentSum;
                    }
                }
            }

        }, 0);

    }, 0);

    return count;
}

console.log(solution([
    ['0', 'K', '0', 'K', '0'],
    ['K', '0', '0', '0', 'K'],
    ['0', '0', 'K', '0', '0'],
    ['K', '0', '0', '0', 'K'],
    ['0', 'K', '0', 'K', '0']
]));