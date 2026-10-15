# Task 2.1 — Collections Research

## 1. What Is Each One?

### Dictionary

- It stores pairs of keys and values.
- You use a key to find its value.
- You can add, remove, and change items.

### IReadOnlyDictionary

- It is an interface for reading key-value pairs.
- You can look at the data, but you cannot change it through this interface.
- It does not store data by itself. A class, such as `Dictionary`, can provide the data.

### SortedDictionary

- It is like `Dictionary`.
- But it keeps the keys sorted, from small to large or A to Z.

## 2. IReadOnlyDictionary vs Dictionary

- **Dictionary:** You can read and change items.
- **IReadOnlyDictionary:** You can only read items through this interface.

### Why Does a Public Method Return IReadOnlyDictionary?

1. **It is safer.** Callers cannot add or remove items through this interface.
2. **It is efficient.** You do not need to make a copy of the dictionary.
3. **It is clear.** It tells callers that the data is for reading.

**Important:** The original dictionary can still change. If its owner changes the data, you may see those changes.

## 3. SortedDictionary vs Dictionary

### Order

- **Dictionary:** It does not guarantee that items are sorted by key.
- **SortedDictionary:** It keeps items sorted by key.

### Speed

- **Dictionary:** It finds a key in average O(1) time.
- **SortedDictionary:** It finds a key in O(log n) time because it uses a balanced search tree.

So, `Dictionary` is usually faster for finding items, while `SortedDictionary` keeps the keys sorted.

## 4. When Should You Use SortedDictionary?

Use `SortedDictionary` when:

- You need keys in sorted order, such as names from A to Z.
- You want the items to stay sorted when you add or remove items.

Use `Dictionary` when:

- You need fast lookups by key.
- You do not need the keys to be sorted.
