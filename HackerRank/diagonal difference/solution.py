def diagonalDifference(arr):
    n = len(arr) - 1
    dlr = 0
    drl = 0

    for i in range(n + 1):
        dlr += arr[i][i]
        drl += arr[i][n - i]

    return abs(dlr - drl)
