function solution(num) {
    let alphabetPosition = 26;
    let result = [];

    while (num > 0) {
        let val = alphabetPosition == 1 ? 1 : 3;

        for (let j = 4; j <= alphabetPosition; j++) {
            val *= j;
        }

        if (num < val) {
            alphabetPosition--;
            continue;
        }

        console.log(num);
        console.log(`Alphabet position : ${alphabetPosition}`);
        num -= val;
        const charCode = alphabetPosition == 1 ? 65 : 63 + alphabetPosition;
        result.push(String.fromCharCode(charCode));

        if (num - val < 0) {
            alphabetPosition--;
        }
    }

    console.log(result.reverse().join(''));
}


//AABC
//f() => n*p + p, where 'p' == previous character and 'n' is the consecutive number
//progression => n(n-1 + p) + p
//doc => B = 2*1 + 1; C = 3(2*1 + 1) + 2*1 + 1; D = 4(3(2*1 + 1)) + 3(2*1 + 1) B = 3, C = 12, D = 60, E = 360

solution(20);