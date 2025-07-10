def miniMaxSum(arr):
    min_sum = 0
    max_sum = 0

    ar = sorted(arr)
    n = len(arr) - 1

    for i in range(n + 1):
        if 1 <= ar[0] <= 10**9 and ar[n] <= 10**9:
            if i <= n - 1:
                min_sum += ar[i]
            if i > 0:
                max_sum += ar[i]

    print(f"{min_sum} {max_sum}")
