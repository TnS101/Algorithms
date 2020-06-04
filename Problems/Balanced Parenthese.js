function solution(input) {
    if (input.length == 1 || input.length % 2 != 0) return "NO";

    let counter = input.length - 1;
    for (let index = 0; index < input.length / 2; index++) {
        let diff = 0;

        input[index] == '(' ? diff = -1 : diff = -2;

        if (input[index].charCodeAt() - input[counter].charCodeAt() != diff) {
            return "NO";
        }
        counter--;
    }
    return "YES";
}