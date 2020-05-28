var maxArea = function(height) {
    let largest = height[0];

    if (height.length < 3) {
        if (largest == height[1]) {
            //console.log(largest);
            return largest;
        }
        return largest < height[1] ? largest : height[1];
    }

    for (let index = 1; index < height.length; index++) {
        let element = height[index];

        if (element >= largest) {
            largest = element;
        }

        let diff = largest * (height.length - 1) - (element * index);

        if (diff >= largest * height.length - index - element * index) {
            console.log(element * (index - 1), element, index);
            return element * (index - 1);
        }
    }
};

maxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
maxArea([1, 2, 1]);