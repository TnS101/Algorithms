var isAnagram = function(s, t) {

    if (s == '' && t == '') return true;

    if (s.length != t.length) return false;

    let sum1 = 0;
    let sum2 = 0;

    for (let i = 0; i < s.length; i++) {
        if (t.includes(s.charAt(i)) == false) return false;
        sum1 += s.charAt(i).charCodeAt(0);
        sum2 += t.charAt(i).charCodeAt(0);
    }

    if (sum1 == sum2) return true;

    return false;
};

console.log(isAnagram(s = "ab", t = "ba"));
console.log(isAnagram(s = "anagram", t = "nagaram"));
console.log(isAnagram(s = "ac", t = "bb"));