var maxFreq = function(s, maxLetters, minSize, maxSize) {
    let substring = '';
    let letters = 0;
    let reverse = s.split('').reverse().join('');

    for (let index = 0; index < s.length; index++) {

        if (substring.length >= minSize && substring.length <= maxSize && s.includes(substring)) {
            s = s.slice(index, s.length);
            reverse = reverse.slice(reverse.length, index);
            letters++;
            substring = '';

            if (reverse.includes(substring)) {
                letters++;
            }
        }
        substring += s[index];
        s.replace(s[index], '');
        console.log(s);
    }

    console.log(letters < maxLetters ? letters : maxLetters);
    return letters < maxLetters ? letters : maxLetters;
};

maxFreq(s = "abcde", maxLetters = 2, minSize = 3, maxSize = 3);
maxFreq(s = "aababcaab", maxLetters = 2, minSize = 3, maxSize = 4);