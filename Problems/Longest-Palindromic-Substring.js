var longestPalindrome = function(s) {
    let result = '';
    if (s == null || s.length < 1) return "";

    if (s.length < 2) return s;

    for (let i = 0; i <= s.length; i++) {
        for (let j = 1; j <= s.length; j++) {
            let array = s.slice(i, j);
            if (array.split('').reverse('').join('') == array.split('').join('') && array.length > result.length) {
                result = array.split('').join('');
            }
        }
    }

    return result;
};