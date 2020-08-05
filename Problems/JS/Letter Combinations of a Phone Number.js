var letterCombinations = function (digits) {
    const combinations = [{
        key: '2',
        value: ['a', 'b', 'c']
    }, {
        key: '3',
        value: ['d', 'e', 'f']
    }];
    const result = [];
    for (let i = 0; i < digits.length; i++) {
        const elements = combinations.find(c => c.key == digits[i]).value;
        for (let j = 0; j < elements.length; j++) {
            for (let e = 0; e < digits.length; e++) {
                if (digits[i + 1] === undefined) return result;
                const secondElements = combinations.find(c => c.key == digits[i + 1]).value;
                for (let z = 0; z < secondElements.length; z++) {
                    result.push(elements[j] + secondElements[z]);
                }
                break;
            }
        }
    }

    return result;
};

console.log(letterCombinations("23"));