# Part 02 — answers

---

## Reports

- What was the problem? The three exporters had the same code.
- What did you change?  I moved the shared code to an abstract class called ReportGenerator.
- Why did you choose that approach?  The abstract class keeps the steps in one place, and each exporter only formats the report.

- An abstract class is better than interface because all exporters share the same export steps. 
- It keeps these steps in one place and lets each exporter implement only its own format. 
- An interface defines a contract, but it does not share this common implementation in the same way.

---

## Enrollment

- What was the problem?
- What did you change?
- Why did you choose that approach?
