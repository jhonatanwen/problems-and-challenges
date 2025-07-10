def countingValleys(steps, path):
    path_array = list(path)
    sea_level = 0
    act_step = 0
    last_step = 0
    valleys = 0

    for i in range(steps):
        if path_array[i] == "U":
            last_step = act_step
            act_step += 1
        elif path_array[i] == "D":
            last_step = act_step
            act_step -= 1

        if i > 0:
            if act_step > last_step and act_step == sea_level:
                valleys += 1

    return valleys
