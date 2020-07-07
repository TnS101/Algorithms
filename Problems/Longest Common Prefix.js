var longestCommonPrefix = function (strs) {
    if (strs.length == 0) return '';
    var result = '';
    for (let i = 0; i < strs.length; i++) {
        const row = strs[i];
        for (let j = 0; j < row.length; j++) {
            const col = row[j];
            var count = 0;
            for (let k = i; k < strs.length; k++) {
                if (strs[k][j] == col) {
                    count++;
                }

                if (count == strs.length && strs[k][0] == row[0]) {
                    result += col;
                    break;
                }
            }

        }
    }

    return result;
};

console.log(longestCommonPrefix(["aca", "cba"]));