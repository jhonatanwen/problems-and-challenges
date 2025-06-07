function birthdayCakeCandles(candles) {
  let n = candles.length,
    k = n - 1,
    blown;
  //The use of the ".sort()" bellow here, whith the parameter being the function '(a,b) => b - a', is to give the array a numerically descending organization so we can work with it more easily.
  let c = candles.sort((a, b) => b - a);
  if (1 <= n <= 10 ** 5 && 1 <= c[k] && c[0] <= 10 ** 7) {
    if (c[0] != c[1]) {
      blown = 1;
    } else {
      blown = 2;
      for (let i = 1; i < k; i++) {
        if (c[i] == c[i + 1] && c[0] == c[i]) {
          blown++;
        }
      }
    }
  }
  return blown;
}
