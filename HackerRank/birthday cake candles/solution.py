def birthdayCakeCandles(candles):
    n = len(candles)
    k = n - 1

    c = sorted(candles, reverse=True)

    if 1 <= n <= 10**5 and 1 <= c[k] <= 10**7 and c[0] <= 10**7:
        if c[0] != c[1]:
            blown = 1
        else:
            blown = 2
            for i in range(1, k):
                if c[i] == c[i + 1] and c[0] == c[i]:
                    blown += 1
    else:
        blown = 0

    return blown
