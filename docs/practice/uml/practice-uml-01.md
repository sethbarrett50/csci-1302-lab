# Practice UML 01 — “Library Book”

## Goal
Create a UML class diagram, then implement it in C#.

## Requirements
Design a `Book` class with:
- `Title` (string)
- `Author` (string)
- `IsCheckedOut` (bool)

And a `Library` class that:
- stores a collection of books
- can add a book
- can search by title (case-insensitive is a nice bonus)
- can check out / return a book

## Self-check
- Does your UML show attributes + methods?
- Do your C# classes match the diagram?
- Can you add 2–3 books and check one out?

## Hint
Start with the simplest version: no fancy UI, just `Console.WriteLine` tests in `Main`.