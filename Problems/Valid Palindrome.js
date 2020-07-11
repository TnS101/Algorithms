var isPalindrome = function (s) {
    if (s.length <= 1) return true;
    const result = [];
    for (let i = 0; i < s.length; i++) {
        const charCode = s[i].charCodeAt(0);

        if (charCode >= 48 && charCode <= 57) return false;

        if (charCode >= 65 && charCode <= 90 || charCode >= 97 && charCode <= 122) {
            result.unshift(s[i]);
        }
    }

    if (result.join('').toLowerCase() === result.reverse('').join('').toLowerCase()) {
        return true;
    }

    return false;
};

console.log(isPalindrome("0P"));