var maxProfit = function (prices) {
    let sum = 0;
    for (let i = 0; i < prices.length; i++) {
        if (i % 2 != 0) {
            const buy = prices[i];
            for (let j = i; j < prices.length; j++) {
                const element = prices[j];
                if (element - buy > sum) {
                    sum = element - buy;
                }
            }
        }
    }

    return sum;
};

console.log(maxProfit([7, 6, 4, 3, 1]));