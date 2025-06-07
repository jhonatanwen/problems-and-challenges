function sockMerchant(n, ar) {
  let pair = 0;

  for (let i = 0; i < n; i++) {
    for (let j = i + 1; j < n; j++) {
      if (ar[i] === ar[j] && ar[i] !== null) {
        pair++;
        ar[j] = null;
        break;
      }
    }
  }

  return pair;
}
