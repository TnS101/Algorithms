var islandPerimeter = function(grid) {
    let result = 0;

    grid.reduce(function(acc, curr, i) {
        const row = grid[i];
        row.reduce(function(acc, curr, j) {
            if (row[j] == 1) {
                if (row[j + 1] != 1) result++;
                if (row[j - 1] != 1) result++;

                if (grid[i + 1] != undefined && grid[i + 1][j] != 1) result++;
                if (grid[i - 1] != undefined && grid[i - 1][j] != 1) result++;

                if (grid[i + 1] === undefined) result++;
                if (grid[i - 1] === undefined) result++;

            }
        }, 0);
    }, 0);

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