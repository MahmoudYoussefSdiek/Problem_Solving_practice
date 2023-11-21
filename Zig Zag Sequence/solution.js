function findZigZagSequence(a, n) {
    a.sort();
    const mid = Math.floor(n / 2);
    [a[mid], a[n - 1]] = [a[n - 1], a[mid]];

    let st = mid + 1;
    let ed = n - 2;
    while (st <= ed) {
        [a[st], a[ed]] = [a[ed], a[st]];
        st++;
        ed--;
    }

    return a;
}

function processData(input) {
    const lines = input.trim().split('\n');
    const testCases = parseInt(lines[0]);

    let currentIndex = 1;
    for (let i = 0; i < testCases; i++) {
        const n = parseInt(lines[currentIndex]);
        const a = lines[currentIndex + 1].split(' ').map(Number);

        const result = findZigZagSequence(a, n);

        console.log(result.join(' '));

        currentIndex += 2;
    }
}

process.stdin.resume();
process.stdin.setEncoding("utf-8");
let _input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
    processData(_input);
});