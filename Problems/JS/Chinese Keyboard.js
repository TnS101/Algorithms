function solution(input) {
    let line1 = ['q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'];
    let line2 = ['a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'];
    let line3 = ['z', 'x', 'c', 'v', 'b', 'n', 'm'];
    let result = [];

    let array = input.split(', ');

    array.reduce(function(pr, word, i) {
        let checkLine = [];
        let counter = 0;

        for (let j = 0; j < word.length; j++) {
            let char = word[j].toLowerCase();
            if (j == 0) {
                if (line1.includes(char)) {
                    checkLine = line1;
                } else if (line2.includes(char)) {
                    checkLine = line2;
                } else {
                    checkLine = line3;
                }
            }

            if (checkLine.includes(char)) {
                counter++;
            } else {
                break;
            }

            if (counter == word.length) {
                result.push(word);
            }
        }
    }, 0);

    return result.join(', ');
}

console.log(solution('Qwerty, Telerik, Potter, Harry, Queue'));