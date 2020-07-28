function solution(matrix) {
    let counter = 0;
    for (let i = 0; i < matrix.length; i++) {
        const row = matrix[i];
        for (let j = 0; j < row.length; j++) {
            const cur = matrix[i, j];
            if (cur == matrix[i, j + 1] && cur == matrix[i + 1, j] && cur == matrix[i + 1, j + 1]) {
                counter++;
                i++;
            }
        }
    }

    return counter;
}

console.log(solution([
    ['A', 'B', 'B', 'D'],
    ['E', 'B', 'B', 'B'],
    ['I', 'J', 'B', 'B']
]));