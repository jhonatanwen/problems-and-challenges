public static int pickingNumbers(List<Integer> a) {
  Map<Integer, Integer> freq = new HashMap<>();
  for (int num : a) {
      freq.put(num, freq.getOrDefault(num, 0) + 1);
  }

  int maxLength = 0;
  for (int num : freq.keySet()) {
      int option1 = freq.get(num);
      int option2 = freq.get(num);
      if (freq.containsKey(num + 1)) {
          option2 += freq.get(num + 1);
      }
      int bestForThisNum = Math.max(option1, option2);
      maxLength = Math.max(maxLength, bestForThisNum);
  }
  return maxLength;
}
