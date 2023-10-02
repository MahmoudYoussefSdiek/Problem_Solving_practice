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
 * Complete the 'plusMinus' function below.
 *
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

function plusMinus(arr) {
    let positive_count = 0;
    let negative_count = 0;
    let zero_count = 0;

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > 0)
            positive_count++;
        else if (arr[i] < 0)
            negative_count++;
        else
            zero_count++;
    }

    console.log((positive_count / arr.length).toFixed(6));
    console.log((negative_count / arr.length).toFixed(6));
    console.log((zero_count / arr.length).toFixed(6));
}

function main() {
    const n = parseInt(readLine().trim(), 10);

    const arr = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));

    plusMinus(arr);
}
