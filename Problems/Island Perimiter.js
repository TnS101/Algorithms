var islandPerimeter = function(grid) {
    let result = 0;
    for (let i = 0; i < grid.length; i++) {
        const row = grid[i];
        for (let j = 0; j < row.length; j++) {
            if (row[j] == 1) {
                if (row[j + 1] != 1) result++;
                if (row[j - 1] != 1) result++;

                if (grid[i + 1] != undefined && grid[i + 1][j] != 1) result++;
                if (grid[i - 1] != undefined && grid[i - 1][j] != 1) result++;

                if (grid[i + 1] === undefined) result++;
                if (grid[i - 1] === undefined) result++;

            }
        }
    }

    return result;
};
console.log(islandPerimeter([
    [0, 1, 0, 0],
    [1, 1, 1, 0],
    [0, 1, 0, 0],
    [1, 1, 0, 0]
]));
console.log(islandPerimeter([
    [1, 1]
]));