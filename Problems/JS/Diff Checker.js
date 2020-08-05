function solution(arr1, arr2) {
    let count = 0;
    arr1.length > arr2.length ? count = arr1.length : count = arr2.length;

    for (let i = 0; i < count; i++) {
        let first = arr1[i];
        let second = arr2[i];
        let char = '';

        first == second ? char = '+' : char = '-';

        if (first == null) first = 'x';
        else if (second == null) second = 'x';

        console.log(`${char} ${first} ${second}`);
    }
}

solution([1, 2, 3, 4, 5, 7, 12, 10], [1, 2, 3, 4]);