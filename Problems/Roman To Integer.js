var romanToInt = function(s) {
    const map = new Map([['I',1], ['V',5], ['X',10],
    ['L', 50],['C',100],['D', 500],['M', 1000]]);
    
    var sum = 0;
    for (let index = 0; index < s.length; index++) {
        const current = map.get(s[index]);
        const next = map.get(s[index + 1]);
        if (current < next)
        {
            sum += next - current;
            index++;
        }else
        {
            sum += current;
        }
    }

    return sum;
};

console.log(romanToInt('MCMXCIV'));