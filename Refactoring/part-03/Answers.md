# Part 03 — answers

---

## BlockedUsers

- **Time complexity before:** O(n * m)
- **Time (ms) before:** 42 ms
- **What did you change?** I replaced `List<int>` with `HashSet<int>` to make lookups faster.
- **Time complexity after:** O(n + m) average
- **Time (ms) after:** 0 ms

---

## Students

- **What was the problem?** The catalog created one million students even though the program printed only three.
- **What did you change?** I used `yield return` to create students only when requested, so the program creates only the first three students.