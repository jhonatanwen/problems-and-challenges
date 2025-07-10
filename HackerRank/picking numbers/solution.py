def pickingNumbers(a):
    freq = {}
    for num in a:
        freq[num] = freq.get(num, 0) + 1

    max_length = 0
    for num in freq.keys():
        option1 = freq[num]
        option2 = freq[num]

        if num + 1 in freq:
            option2 += freq[num + 1]

        best_for_this_num = max(option1, option2)
        max_length = max(max_length, best_for_this_num)

    return max_length
