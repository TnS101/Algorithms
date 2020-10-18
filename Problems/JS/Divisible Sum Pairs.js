function solution(k, arr) {
    var result = 0;
    var checker = arr[0];
    var counter = 1;

    for (let i = 1; i < arr.length; i++) {
        if (checker + arr[i] % k) {
            result++;
        }

        if (i + 1 == arr.length) {
            checker = arr[counter];
            counter++;
        }
    }

    return result;
}

console.log(solution(5, [1, 3, 2, 6, 1, 2]));