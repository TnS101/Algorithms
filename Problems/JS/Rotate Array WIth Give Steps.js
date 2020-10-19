function solution(arr, steps) {
    if (steps % arr.length != 0) {
        var diff = steps % arr.length;
        steps -= diff;

        for (let i = 0; i < diff; i++) {
            arr.push(arr.shift());
        }

        if ((steps / arr.length) % 2 != 0) {
            arr.reverse();
        }

    } else {
        for (let i = 0; i < steps; i++) {
            arr.push(arr.shift());
        }
    }

    console.log(arr.join(', '));
}

solution([1, 2, 3, 4, 5, 6], 7);