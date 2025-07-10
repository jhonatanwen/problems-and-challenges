def isPalindrome(x):
    # Convert to string and check if it reads the same forwards and backwards
    s = str(x)
    return s == s[::-1]
