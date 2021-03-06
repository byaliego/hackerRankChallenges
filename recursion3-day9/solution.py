#!/bin/python

import math
import os
import random
import re
import sys

#
# Complete the 'factorial' function below.
#
# The function is expected to return an INTEGER.
# The function accepts INTEGER n as parameter.
#

def factorial(n):
    if n==1 or n==0:
        result = 1
    else:     
        result = n * factorial(n-1)
    
    return result

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(raw_input().strip())

    result = factorial(n)

    fptr.write(str(result) + '\n')

    fptr.close()
