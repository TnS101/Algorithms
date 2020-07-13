var spiralOrder = function (matrix) {
    const result = [];

    for (let i = 0; i < matrix.length - 1; i++) {
        const row = matrix[i];
        for (let j = 0; j < row.length; j++) {
            result.push(matrix[0][j]);
            if (result.length >= row.length) break;
            continue;
        }
        for (let j = 1; j < row.length - 1; j++) {
            //result.push(row[row.length - 1]);
            if (result.length >= row.length) break;
            continue;
        }
    }

    return result;
};

console.log(spiralOrder([
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]));