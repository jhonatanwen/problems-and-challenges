import math

def pages_faces_to_array(n):
    page_faces = [1]
    k = 1

    if n % 2 == 0:
        for i in range(1, math.floor(n / 2) + 1):
            if 2 * k + 1 == n - 1:
                page_faces.append([2 * k, 2 * k + 1])
                page_faces.append(n)
                break
            page_faces.append([2 * k, 2 * k + 1])
            k += 1
    else:
        for i in range(1, math.floor(n / 2) + 1):
            page_faces.append([2 * k, 2 * k + 1])
            k += 1

    return page_faces

def pageCount(n, p):
    if p == 1 or (p == n and n % 2 == 0):
        return 0

    pages = pages_faces_to_array(n)

    if p - 1 >= n - p:
        pages = pages[::-1]  # reverse

    for i in range(len(pages)):
        if pages[i] == 1 or pages[i] == n:
            continue
        elif isinstance(pages[i], list) and p in pages[i]:
            return i

    return 0
