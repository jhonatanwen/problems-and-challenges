def plusMinus(arr):
    m = len(arr)
    pos = 0
    neg = 0
    zro = 0

    if 0 < m <= 100:
        for i in range(m):
            if -100 <= arr[i] <= 100:
                if arr[i] > 0:
                    pos += 1
                elif arr[i] < 0:
                    neg += 1
                else:
                    zro += 1

        posr = pos / m
        negr = neg / m
        zror = zro / m

        print(f"{posr:.6f}")
        print(f"{negr:.6f}")
        print(f"{zror:.6f}")
