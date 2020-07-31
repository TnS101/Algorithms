function solution(matrix) {
    let counter = 0;

    matrix.reduce(function(acc, curr, i) {
        curr.reduce(function(acc, curr, j) {
            const cur = matrix[i, j];
            if (cur == matrix[i, j + 1] && cur == matrix[i + 1, j] && cur == matrix[i + 1, j + 1]) {
                counter++;
                i++;
            }
        }, 0);

    });

    return counter;
}

console.log(solution([
    ['A', 'B', 'B', 'D'],
    ['E', 'B', 'B', 'B'],
    ['I', 'J', 'B', 'B']
]));