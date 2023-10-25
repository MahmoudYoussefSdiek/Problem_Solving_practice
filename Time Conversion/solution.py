#!/bin/python3

import math
import os
import random
import re
import sys
import datetime

#
# Complete the 'timeConversion' function below.
#
# The function is expected to return a STRING.
# The function accepts STRING s as parameter.
#

def timeConversion(s):
    # Parse the input time string
    time = datetime.datetime.strptime(s, "%I:%M:%S%p")

    # Format the time in 24-hour format
    return time.strftime("%H:%M:%S")

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = timeConversion(s)

    fptr.write(result + '\n')

    fptr.close()
