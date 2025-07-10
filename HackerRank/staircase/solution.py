def staircase(n):
    if 0 < n <= 100:
        for i in range(1, n + 1):
            output = " " * (n - i) + "#" * i
            print(output)
