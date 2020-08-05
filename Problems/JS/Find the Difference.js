var findTheDifference = function (s, t) {

    function sum(string) {
        string.split('').reduce(function (a, b) {
            return a.charCodeAt(0) + b.charCodeAt(0);
        });
    }
    return String.fromCharCode(sum(t) - sum(s));
};

console.log(findTheDifference(s = "abcd",
    t = "abcde"));