var lengthOfLongestSubstring = function(s) {

    let result = '';

    if (s.length < 2) {
        return s.length;
    }

    for (let index = 0; index < s.length; index++) {
        if (s.charAt(index) != s.charAt(index + 1) && !result.includes(s.charAt(index))) {
            result += s.charAt(index);
        } else if (s.charAt(index) == s.charAt(index + 1)) {
            result = result.substring(s.charAt(0, index - 1));
        }
    }

    console.log(result);
    console.log(result.length);
    return result.length;
};

lengthOfLongestSubstring(
    "pwwkew");

lengthOfLongestSubstring(
    "abcabcbb");