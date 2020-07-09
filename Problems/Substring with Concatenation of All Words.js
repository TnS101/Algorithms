var findSubstring = function (s, words) {
    const result = [];
    let counter = 0;
    for (let i = 0; i < s.length * words.join('').length; i++) {
        for (let j = 0; j < words.length; j++) {
            const substring = s.substr((i, words.join('').length)).split('');
            if (substring.filter(w => w == words[j]).length == 1 || substring.includes(words[j]) === false) {
                s = s.split('').splice(i, words.join('').length).join('');
                break;
            }

            counter++;

            if (counter == words.length) {
                result.push(i);
                counter = 0;
                s = s.split('').splice(i, words.join('').length).join('');
                console.log(s);
                i += words.join('').length - 1;
            }
        }
    }

    return result;
}
console.log(findSubstring("barfoofoobarthefoobarman",
    ["bar", "foo", "the"]));