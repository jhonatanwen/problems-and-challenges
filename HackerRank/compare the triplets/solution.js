function compareTriplets(a, b) {
  const comparison = [];
  var alice = 0;
  var bob = 0;
  for (let x = 0; x < a.length; x++) {
    if (a[x] > b[x]) {
      alice++;
    } else if (a[x] < b[x]) {
      bob++;
    } else {
      continue;
    }
  }
  comparison.push(alice);
  comparison.push(bob);
  return comparison;
}
