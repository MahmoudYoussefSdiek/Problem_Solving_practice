#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'countingSort' function below.
#
# The function is expected to return an INTEGER_ARRAY.
# The function accepts INTEGER_ARRAY arr as parameter.
#

def countingSort(arr):
    # Find the maximum value in the array
    max_value = max(arr)

    # Allocate memory for the count array and initialize it to 0
    count_arr = [0] * (max_value + 1)

    # Count the number of occurrences of each value in the array
    for value in arr:
        count_arr[value] += 1

    return count_arr

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    arr = list(map(int, input().rstrip().split()))

    result = countingSort(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
