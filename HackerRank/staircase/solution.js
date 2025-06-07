function staircase(n) {
  let output = "";
  let sharps = "#";
  let spaces = " ";
  if (0 < n && n <= 100) {
    for (let i = 1; i <= n; i++) {
      output = spaces.repeat(n - i) + sharps.repeat(i);
      console.log(output);
    }
  }
}
//.repeat is cool
