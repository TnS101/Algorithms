var intToRoman = function (num) {
    let output = '';
    if (num > 1000) {
        num -= 1000;
        output += 'M';
    }
    if (num >= 900) {
        num -= 900;
        output += 'CM'
    }

    if (num > 500) {
        num -= 500;
        output += 'D';
    }
    if (num >= 400) {
        num -= 400;
        output += 'CD';
    }

    if (num > 100) {
        num -= 100;
        output += 'C';
    }
    if (num >= 90) {
        num -= 90;
        output += 'XC';
    }

    if (num > 50) {
        num -= 50;
        output += 'L';
    }
    if (num >= 40) {
        num -= 40;
        output += 'XL';
    }

    if (num > 10) {
        num -= 10;
        output += 'X';
    }
    if (num == 9) {
        num -= 9;
        output += 'IX'
    }

    if (num > 5) {
        num -= 5;
        output += 'V';
    }
    if (num == 4) {
        num -= 4;
        output += 'IV';
    }

    if (num > 1) {
        num -= 1;
        output += 'I';
    }

    return output;
};

console.log(intToRoman(1994));