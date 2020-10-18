function solution(n, p) {
    if (n == 2) {
        return 0;
    }

    if (n - p == 1 && n % 2 == 0) {
        return 1;
    }

    var bot = p;
    var top = n - p;

    if (bot < top) {
        return p / 2;
    }

    return top / 2;
}

console.log(solution(6, 2));