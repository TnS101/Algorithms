function solution(matrix) {
    let result = [];
    let sum = 0;

    for (let i = 0; i < matrix.length; i++) {
        const row = matrix[i];
        let currentSum = 0;
        let currentResult = [];
        let nextCounter = 0;

        for (let j = 0; j < row.length; j++) {
            let cur = matrix[i + j];

            if (j % 3 == 0) {
                if (currentSum > sum) {
                    sum = currentSum;
                    result = currentResult;
                }
                currentSum = 0;
                currentResult = [];
                cur = matrix[nextCounter];
                nextCounter += 3;
            }

            if (cur == undefined) break;

            const arr = [];
            for (let z = 0; z < 3; z++) {
                currentSum += cur[z + nextCounter - 1];
                arr.push(cur[z + nextCounter - 1]);
            }
            currentResult.push(arr);
        }


    }
    console.log(sum);
    return result;
}

console.log(solution([
    [1, 5, 5, 2, 4],
    [2, 1, 4, 14, 3],
    [3, 7, 11, 2, 8],
    [4, 8, 12, 16, 4]
]));