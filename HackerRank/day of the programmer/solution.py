def leapDay(value, y):
    if value:
        return f"12.09.{y}"
    else:
        return f"13.09.{y}"

def dayOfProgrammer(year):
    if 1700 <= year <= 1917:
        if year % 4 == 0:
            return leapDay(True, year)
        else:
            return leapDay(False, year)

    if year == 1918:
        return "26.09.1918"

    if (year % 400 == 0) or (year % 4 == 0 and year % 100 != 0):
        return leapDay(True, year)
    else:
        return leapDay(False, year)
