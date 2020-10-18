function solution(i, j, k) {
    let result = 0;

    for (let z = i; z <= j; z++) {
        let sum = z - getPalindrome(z.toString());

        if ((sum / k) % 1 == 0) {
            result++;
        }
    }

    return result;
}

function getPalindrome(str) {
    return Number(str.split('').reverse().join(''));
}

console.log(solution(20, 23, 6));