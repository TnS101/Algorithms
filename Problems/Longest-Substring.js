var lengthOfLongestSubstring = function(s) {
    let result = '';
    let map = new Map();

    if (s.length < 2) {
        return s.length;
    }

    for (let index = 0; index < s.length; index++) {
        let character = s.charAt(index)
        if (character != map.keys()[index + 1] && !map.has(character)) {
            result += character;
        }

        map.set(character, index);
    }

    console.log(result);
    console.log(result.length);
    return result.length;
};

lengthOfLongestSubstring(
    "pwwkew");

lengthOfLongestSubstring(
    "abcabcbb");