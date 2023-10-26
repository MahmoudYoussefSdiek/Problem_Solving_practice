'use strict';

const fs = require('fs');

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
 * Complete the 'timeConversion' function below.
 *
 * The function is expected to return a STRING.
 * The function accepts STRING s as parameter.
 */

function timeConversion(s) {
    // Check if the input time string is in the expected format
    const regex = /^([0-9]|0[0-9]|1[0-2]):([0-5][0-9]):([0-5][0-9])(AM|PM)$/;
    if (!regex.test(s)) {
        return "Invalid input format";
    }

    // Parse the input time string
    const hour = parseInt(s.slice(0, 2));
    const minute = parseInt(s.slice(3, 5));
    const second = parseInt(s.slice(6, 8));
    const isPM = s.slice(8, 10) === "PM";
    let time = new Date();
    time.setHours(hour + (isPM && hour !== 12 ? 12 : 0));
    time.setMinutes(minute);
    time.setSeconds(second);

    // Check if the resulting Date object is valid
    if (isNaN(time.getTime())) {
        return "Invalid time value";
    }

    // Format the time in 24-hour format
    return time.toISOString().slice(11, 19);

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const s = readLine();

    const result = timeConversion(s);

    ws.write(result + '\n');

    ws.end();
}