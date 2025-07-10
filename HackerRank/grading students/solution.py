import math

def gradingStudents(grades):
    n = len(grades)
    k = n - 1
    new_grades = []

    if 1 <= n <= 60:
        for i in range(k + 1):
            cond = math.ceil(grades[i] / 5) * 5

            if 0 <= grades[i] <= 100:
                if grades[i] >= 38 and abs(grades[i] - cond) < 3:
                    new_grades.append(cond)
                else:
                    new_grades.append(grades[i])

    return new_grades
