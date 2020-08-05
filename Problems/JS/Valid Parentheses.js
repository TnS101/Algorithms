var isValid = function (s) {
    for (let i = 0; i < s.length; i++) {
        const char = s[i];
        var validChar = validCharGen(char);
        console.log(s);
        if (s.split('').find(c => c == validChar) === undefined || s.length % 2 != 0) return false;

        validChar = s.split('').filter(c => c == validChar);
        if (s.indexOf(char) - s.indexOf(validChar) % 2 == 0) return false;
        s = s.split('').splice(s.charAt(char), 1).join('');
        s = s.split('').splice(s.charAt(validChar), 1).join('');
        console.log(s);
    }

    function validCharGen(char) {
        if (char == '(') return ')';
        if (char == '[') return ']';
        if (char == '{') return '}';
        if (char == ')') return '(';
        if (char == ']') return '[';
        if (char == '}') return '{';
    }

    return true;
};

console.log(isValid('(([]){})'));
console.log(isValid('()'));
console.log(isValid(
    "([)]"));
console.log(isValid('{{)}'));