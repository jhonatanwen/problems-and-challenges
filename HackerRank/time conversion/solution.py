def timeConversion(s):
    n = s[:2]

    if "AM" in s:
        if n == "12":
            hrs = int(n) - 12
            hrs_str = f"{hrs:02d}"
            return hrs_str + s[2:8]
        else:
            return s[:8]
    elif n != "12":
        hrs = int(n) + 12
        hrs_str = str(hrs)
        return hrs_str + s[2:8]
    else:
        return s[:8]
