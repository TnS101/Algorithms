var lengthOfLongestSubstring = function(s) {
    let result = '';

    if (s.length < 2) {
        return s.length;
    }

    let lastIndex = 0;
    let character = s[0];

    for (let index = 0; index < s.length; index++) {

        if (character != s[index] && !result.includes(character)) {
            result = s.substr(lastIndex, index);
        } else {
            lastIndex = index;
        }

        character = s[index];
    }
    console.log(result);
    console.log(result.length);
    return result.length;
};

lengthOfLongestSubstring(
    "pwwkew");

lengthOfLongestSubstring(
    "abcabcbb");

lengthOfLongestSubstring("bbbbb");