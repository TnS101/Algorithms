var climbStairs = function (n) {
    let ways = 1;

    if (n - 1 > 0) {
        for (let i = 0; i < n; i++) {
            if (n - 1 > 0) {
                ways++;
            }
            if (n - 2 > 0) {
                ways++;
            }
        }
    }

    return ways;
};

console.log(climbStairs(5));