function solution(times, input) {
    const result = [];
    const splitted = input.split('');

    for (let i = 0; i < times; i++) {
        const last = splitted.pop();
        result.push(splitted.join(''));
        splitted.unshift(last);
    }

    return result;
}

console.log(solution(5, 'SoftUni'));