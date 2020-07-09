var combinationSum = function (candidates, target) {
    let sum = 0;
    const result = [];
    for (let i = 0; i < candidates.length; i++) {
        const element = candidates[i];
        let currentSet = [];
        while (sum <= target - element) {

            if (sum + candidates[i + 1] == target) {
                directPush(currentSet, candidates[i + 1]);
                break;
            }

            if (sum + candidates[i - 1] == target) {
                directPush(currentSet, candidates[i - 1]);
                break;
            }

            currentSet.push(element);
            sum += element;
        }
        if (sum == target) {
            result.push(currentSet);

        }
        sum = 0;
    }

    function directPush(currentSet, candidate) {
        currentSet.push(candidate);
        currentSet.sort((a, b) => a - b);
        result.push(currentSet);
        currentSet = [];
    }

    return result;
};

console.log(combinationSum([2, 3, 5], 8));