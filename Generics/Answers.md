## Step 2 — StudentStore vs CourseStore

### What is the same?
- Both stores use a `List` to keep objects.
- Both have the same four methods: `Add`, `GetById`, `GetAll`, and `Remove`.
- Both use similar logic to add, find, and remove objects.
- Both return `null` when an object is not found.

### What is different?
- `StudentStore` stores `Student` objects.
- `CourseStore` stores `Course` objects.
- `Student` has `Id` and `Name`.
- `Course` has `Id`, `Title`, and `Price`.

The main difference is the type of object each store manages. The store logic is almost the same.


## Step 3 — Why GetById Does Not Compile

### Compiler Error

`CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found.`

### Explanation

The compiler does not know what type `T` will be. It can be a `Student`, a `Course`, or another type. Not every type has an `Id` property, so the compiler cannot allow `item.Id` without knowing that `T` supports it.