function solution(n, target) {
    var bot = target;
    var top = n - target;

    if (bot > top) {
        return top / 2;
    }

    return target / 2;
}

console.log(solution(6, 2));