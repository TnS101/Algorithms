var addTwoNumbers = function(l1, l2) {
    let num1 = '';
    let num2 = '';

    for (let index = l1.length - 1; index >= 0; index--) {
        num1 += l1[index];
    }

    for (let index = l2.length - 1; index >= 0; index--) {
        num2 += l2[index];
    }

    let sum = Number(num1) + Number(num2);
    let result = [];
    for (let index = sum.toString().length - 1; index >= 0; index--) {
        result.push(Number(sum.toString().charAt(index)));
    }

    return result;
};

addTwoNumbers([2, 4, 3], [5, 6, 4]);