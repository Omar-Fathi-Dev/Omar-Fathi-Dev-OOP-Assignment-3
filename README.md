# C# & .NET Assignment

**Track:** Backend .NET  
**Focus:** Refactoring, Design Patterns, Collections, Generics, and Modern C#

This repository contains four practical assignments completed as part of the .NET Backend learning track. The work focuses on improving existing code, applying design principles, building reusable components, and exploring C# features through implementation and experimentation.

## Repository Structure

```text
.
├── README.md
├── Refactoring/
│   ├── part-01/
│   ├── part-02/
│   └── part-03/
├── Collections/
│   ├── Answers.md
│   └── src/
│       ├── StringValidationExtensions.cs
│       └── Program.cs
├── Generics/
│   ├── Answers.md
│   └── src/
└── LinkedIn/
    └── linked.md
```

## 01. Refactoring Lab

Refactored existing C# applications to improve maintainability, reduce duplication, and make the code easier to extend while preserving expected behavior.

**Key work:**
- Improved shipping-cost calculation and order-processing logic to reduce hard-coded dependencies.
- Used composition to combine notification channels and behaviors without creating a separate class for every combination.
- Applied the **Template Method** pattern to centralize shared report-exporting steps.
- Applied the **Facade** pattern to simplify the enrollment workflow behind a single entry point.
- Optimized blocked-user lookup and used lazy enumeration to avoid generating unnecessary student records.

**Concepts:** SOLID principles, composition over inheritance, Template Method, Facade, performance optimization, and lazy execution.

## 02. Collections & Extension Methods

Explored how to select suitable collections based on lookup performance, uniqueness, ordering, and data-access requirements.

**Key work:**
- Compared `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`, `IEnumerable<T>`, `IReadOnlyDictionary<TKey, TValue>`, and `SortedDictionary<TKey, TValue>`.
- Implemented string-validation extension methods using regular expressions.
- Validated Egyptian mobile phone numbers and Egyptian national ID formats.
- Tested valid and invalid inputs against the required cases without using LINQ in the implemented methods.

**Concepts:** Collections, time complexity, extension methods, regular expressions, and read-only interfaces.

## 03. Generics — One Store for Every Type

Built a reusable generic store incrementally, evolving from separate student and course stores into one type-safe implementation.

**Key work:**
- Created `StudentStore` and `CourseStore`, then replaced duplicated implementations with `Store<T>`.
- Introduced `IHasId` and generic constraints to require stored entities to expose an ID.
- Replaced list-based storage with `Dictionary<int, T>` for efficient ID-based lookups.
- Added duplicate-ID validation and exposed stored items through `IReadOnlyDictionary<int, T>`.
- Implemented generic extension methods for pagination, finding items by ID, and converting collections into ID-keyed dictionaries.
- Tested the implementation with students, courses, duplicate IDs, pagination, and a plain `List<Course>`.

**Concepts:** Generics, interfaces, type constraints, dictionaries, exception handling, extension methods, and iterators.

## 04. LinkedIn Technical Posts

Published four posts explaining C# and .NET concepts through practical examples and experiments.

| Topic | Focus | Link |
|---|---|---|
| HashSet vs. List Contains | Lookup performance and time complexity | [Read post](https://lnkd.in/p/dQEDRmtR) |
| The `yield` Keyword | Iterators and lazy execution | [Read post](https://lnkd.in/p/dHqtUvUg) |
| `Span<T>` | Memory-efficient slicing and limitations | [Read post](https://lnkd.in/p/dWaJ_wHZ) |
| Extension Members in .NET 10 | C# 14 extension syntax and capabilities | [Read post](https://lnkd.in/p/dbZkyZ7u) |

All four links are also collected in [`LinkedIn/linked.md`](LinkedIn/linked.md).

## Technologies & Tools

- **Language:** C#
- **Platform:** .NET
- **IDE:** JetBrains Rider
- **Version Control:** Git and GitHub
- **Practices:** Refactoring, incremental commits, and pull-request workflow

## Key Learnings

- Refactor working code without changing its expected behavior.
- Reduce coupling and duplication through appropriate design choices.
- Choose collections according to the operations and guarantees required.
- Build reusable, type-safe generic components.
- Improve performance and avoid unnecessary work through suitable data structures and lazy execution.
- Communicate technical concepts through implementation and knowledge sharing.

---

*Part of my ongoing journey toward becoming a .NET Backend Developer.*