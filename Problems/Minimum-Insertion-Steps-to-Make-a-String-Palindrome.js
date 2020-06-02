var minInsertions = function(s) {
    let reverse = s.split('').reverse().join('');

    let steps = 0;

    if (reverse == s) return steps;

    console.log(reverse);

};

minInsertions('mbadm'); //mbd a dbm