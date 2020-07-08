var isValid = function (s) {
    for (let i = 0; i < s.length; i++) {
        const char = s[i];
        var validChar = validCharGen(char);
        if (s.split('').find(c => c == validChar) === undefined) return false;

        validChar = s.split('').find(c => c == validChar);
        if (s.indexOf(char) - s.indexOf(validChar) % 2 == 0) return false;
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