var generate = function (numRows) {
    const result = [
        [1]
    ];
    for (let i = 1; i < numRows; i++) {
        let nextRow = [1];
        for (let j = 0; j < result.length; j++) {
            const previousRow = result[j];
            for (let k = 0; k < previousRow.length; k++) {
                if (previousRow[k + 1] == null) {
                    break;
                }
                nextRow.push(Number(previousRow[k] + previousRow[k + 1]));

                break;
            }
        }
        nextRow.push(1);
        result.push(nextRow);
    }
    return result;
}

console.log(generate(5));