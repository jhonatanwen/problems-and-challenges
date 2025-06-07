//Before anything, can someone explain why tf it says to return 12:01:00 for 12:01:00PM when normally it would be 00:01:00???? That pissed me off.
function timeConversion(s) {
  // The use of that addiction, in "n" variable, of the first and the second character of the string is to know if it is 12 or not and then make it a Number to manibulate it's value.
  let n = s[0] + s[1];
  if (s.includes("AM")) {
    if (n == "12") {
      let hrs = Number(n) - 12;
      hrs = hrs.toString() + "0";
      hrs = hrs + s.slice(2, 8);
      return hrs;
    } else {
      return s.slice(0, 8);
    }
  } else if (n != "12") {
    let hrs = Number(n) + 12;
    hrs = hrs.toString();
    hrs = hrs + s.slice(2, 8);
    return hrs;
  } else {
    return s.slice(0, 8);
  }
}
