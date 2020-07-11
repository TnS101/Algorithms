var deleteDuplicates = function (head) {
    for (let i = 0; i < head.length; i++) {
        if (head[i] == head[i + 1]) head.splice(i, 1);
    }

    return head;
};

console.log(deleteDuplicates([1, 1, 2, 3, 3, 5, 5]));