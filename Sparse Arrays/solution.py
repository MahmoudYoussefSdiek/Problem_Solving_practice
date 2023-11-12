#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'matchingStrings' function below.
#
# The function is expected to return an INTEGER_ARRAY.
# The function accepts following parameters:
#  1. STRING_ARRAY strings
#  2. STRING_ARRAY queries
#

def matchingStrings(strings, queries):
    # Create a dictionary to store the frequency of each string
    string_count = {}

    # Count the frequency of each string in the strings array
    for string in strings:
        if string in string_count:
            string_count[string] += 1
        else:
            string_count[string] = 1

    # Create an array to store the frequency of each query
    query_count = []

    # Count the frequency of each query in the queries array
    for query in queries:
        if query in string_count:
            query_count.append(string_count[query])
        else:
            query_count.append(0)

    return query_count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    strings_count = int(input().strip())

    strings = []

    for _ in range(strings_count):
        strings_item = input()
        strings.append(strings_item)

    queries_count = int(input().strip())

    queries = []

    for _ in range(queries_count):
        queries_item = input()
        queries.append(queries_item)

    res = matchingStrings(strings, queries)

    fptr.write('\n'.join(map(str, res)))
    fptr.write('\n')

    fptr.close()