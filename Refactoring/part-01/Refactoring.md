# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem? It used a switch to choose the carrier.
- What did you change?  I used an interface, so I can add a new carrier without changing the calculator.

---

## OrderProcessor

- What was the problem? It created its own dependencies.
- What did you change?  I used interface and constructor injection, so I can pass different classes to it.

---

## Notifications

- What was the problem? It needed a new class for each combination, like urgent email.
- What did you change?  I used composition, so I can combine a channel with urgent and scheduled features.

---

## Proof

- New carrier file(s): UpsCarrier.cs
- New notification channel file(s): PushNotification.cs
- Existing classes left unchanged? (yes/no): Yes. I added the new carrier and notification channel without changing existing classes. I only updated Program.cs to test them.
