'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the 'miniMaxSum' function below.
 *
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

function miniMaxSum(arr) {
    let sum = 0;
    let min = Number.MAX_SAFE_INTEGER;
    let max = 0;

    // Calculate the sum of all elements in the array
    for (let i = 0; i < arr.length; i++)
        sum += arr[i];

    // Find the minimum and maximum sums
    for (let i = 0; i < arr.length; i++) {
        let tempSum = sum - arr[i];
        if (tempSum < min)
            min = tempSum;
        if (tempSum > max)
            max = tempSum;
    }

    // Print the results
    console.log(`${min} ${max}`);
}

function main() {

    const arr = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));

    miniMaxSum(arr);
}
