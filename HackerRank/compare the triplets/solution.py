def compareTriplets(a, b):
    comparison = []
    alice = 0
    bob = 0

    for x in range(len(a)):
        if a[x] > b[x]:
            alice += 1
        elif a[x] < b[x]:
            bob += 1

    comparison.append(alice)
    comparison.append(bob)
    return comparison
