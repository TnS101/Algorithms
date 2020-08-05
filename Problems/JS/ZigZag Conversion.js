var convert = function(s, numRows) {
    for (let i = 0; i < s.length; i++) {
        const row = s[i];
        for (let j = 0; j < numRows; j++) {
            const col = row[j];
            console.log(col);
            break;
        }
    }
};

convert('string',3);