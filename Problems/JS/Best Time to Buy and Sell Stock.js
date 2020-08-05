var maxProfit = function(prices) {
    let sum = 0;
    prices.reduce(function(pr, curr, i) {
        if (i % 2 != 0) {
            for (let j = i; j < prices.length; j++) {
                const element = prices[j];
                if (element - curr > sum) {
                    sum = element - curr;
                }
            }
        }
    }, 0);

    return sum;
};

console.log(maxProfit([7, 6, 4, 3, 1]));