var maxSideLength = function(mat, threshold) {
    let sum = 0;
    let width = 0;

    for (let i = 0; i < mat.length; i++) {
        for (let j = 0; j < mat.length; j++) {
            sum += mat[j][i];
            width++;

            if (sum <= threshold) {
                if (i + j == j && j > 0) {
                    console.log(width);
                    return width;
                }
            }
        }
    }

    console.log(0);
    return 0;
};

maxSideLength([
    [1, 1, 1, 1],
    [1, 0, 0, 0],
    [1, 0, 0, 0],
    [1, 0, 0, 0]
], threshold = 6); //3

maxSideLength([
    [1, 1, 3, 2, 4, 3, 2],
    [1, 1, 3, 2, 4, 3, 2],
    [1, 1, 3, 2, 4, 3, 2]
], threshold = 4); //2

maxSideLength(mat = [
    [2, 2, 2, 2, 2],
    [2, 2, 2, 2, 2],
    [2, 2, 2, 2, 2],
    [2, 2, 2, 2, 2],
    [2, 2, 2, 2, 2]
], threshold = 1); // 0

maxSideLength(mat = [
    [18, 70],
    [61, 1],
    [25, 85],
    [14, 40],
    [11, 96],
    [97, 96],
    [63, 45]
], threshold = 40184); // 2