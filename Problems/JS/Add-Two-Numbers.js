var addTwoNumbers = function(l1, l2) {
    let num1 = '';
    let num2 = '';

    l1.reduceRight(function(acc, curr) {
        num1 += curr;
    }, 0);

    l2.reduceRight(function(acc, curr) {
        num2 += curr;
    }, 0);

    let sum = Number(num1) + Number(num2);
    let result = [];

    sum.toString().split('').reduceRight(function(acc, curr) {
        result.push(Number(curr));
    }, 0);

    console.log(result);
    return result;
};

addTwoNumbers([2, 4, 3], [5, 6, 4]);