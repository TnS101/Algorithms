var isPalindrome = function(x) {
    return String(x).split('').reverse('').join('') == x ? true : false;
};