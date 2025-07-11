# My Mastermind Game – C# Console Version

## 🧠 Game Description
A C# implementation of the classic Mastermind game using OOP principles.

## 🕹️ How to Play
- The game selects a secret 4-digit code using numbers 0-8 (no duplicates).
- You have a limited number of attempts to guess it.
- After each guess, the game shows:
  - Well placed pieces.
  - Misplaced pieces.

## ⚙️ Usage
Run from terminal:
```
MyMastermind.exe -c 0123 -t 12
```

- `-c` Optional: secret code
- `-t` Optional: max attempts (default: 10)

## 🧱 OOP Principles Used
- Classes and encapsulation
- Static utility classes
- Evaluation logic abstraction

## 📁 Files
- `Program.cs`
- `Game.cs`
- `CodeGenerator.cs`
- `GuessEvaluator.cs`
- `InputValidator.cs`

## 👩‍💻 Author
Developed for Steer 2025 Gameplay Programming Assessment.