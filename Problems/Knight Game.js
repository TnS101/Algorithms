function solution(matrix) {
    let sum = 0;
    let count = 0;
    for (let i = 0; i < matrix.length; i++) {
        const row = matrix[i];
        let currentSum = 0;
        for (let j = 0; j < row.length; j++) {
            const curr = row[j];
            if (curr != 'K') {
                continue;
            }

            if (matrix[i + 2] === undefined || matrix[i - 2] === undefined) break;
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

    return count;
}

console.log(solution([
    ['0', 'K', '0', 'K', '0'],
    ['K', '0', '0', '0', 'K'],
    ['0', '0', 'K', '0', '0'],
    ['K', '0', '0', '0', 'K'],
    ['0', 'K', '0', 'K', '0']
]));