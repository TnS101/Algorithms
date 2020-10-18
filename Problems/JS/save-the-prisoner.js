function solution(prisoners, sweets, start) {
    start--;
    if (sweets < prisoners) {
        return sweets + start;
    }

    if (sweets == prisoners) return start + 1;

    sweets -= prisoners - start;

    while (sweets - prisoners > 0) {
        sweets -= prisoners;
    }

    return sweets;
}

console.log(solution(5, 2, 1));