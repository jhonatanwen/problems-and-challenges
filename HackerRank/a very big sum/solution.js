//before anything, yes. It is exactly the same function for the "simple array sum" problem. In JS both problems have the same solution.
function aVeryBigSum(ar) {
  var res = 0;
  for (var n = 0; n < ar.length; n++) {
    res += ar[n];
  }
  return res;
}
