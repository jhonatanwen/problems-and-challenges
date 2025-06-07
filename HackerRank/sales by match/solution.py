def sockMerchant(n, ar):
    pair = 0

    for i in range(n):
        for j in range(i+1, n):
            if(ar[i] == ar[j] and ar[i] != None):
                pair = pair + 1
                ar[j] = None
                break

    return pair
