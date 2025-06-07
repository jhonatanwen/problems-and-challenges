def getMoneySpent(keyboards, drives, b):
    cost = -1

    for i in keyboards:
        for j in drives:
            if((i + j) <= b and (i + j) > cost):
                cost = i+j

    return cost