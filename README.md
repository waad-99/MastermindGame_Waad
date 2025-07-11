# My Mastermind Game – C# Console Version

## Game Description  
This is a small project I made to practice C#. It’s based on the Mastermind game. I tried to use simple object-oriented programming (OOP) ideas to make the code more organized.

## How to Play  
- The game picks a secret 4-digit code using numbers from 0 to 8.  
- All digits are different.  
- You have a few chances to guess the correct code.  
- After each guess, the game tells you:
  - How many numbers are in the correct place.  
  - How many numbers are correct but in the wrong place.

## How to Run  
Open the terminal or command prompt and run:
```
MyMastermind.exe -c 0123 -t 12
```

- `-c`: (optional) lets you choose the secret code.  
- `-t`: (optional) lets you change how many tries you get. Default is 10.

## What I Used from OOP  
- I made classes for different parts of the game.  
- I tried to keep things simple and clean.  
- I separated the game logic from the input checking.

## Files Included  
- `Program.cs`: The main file that starts everything.  
- `Game.cs`: Handles the game loop.  
- `CodeGenerator.cs`: Makes the random code.  
- `GuessEvaluator.cs`: Checks how good the guess is.  
- `InputValidator.cs`: Makes sure the input is okay.

---
Developed for Steer 2025 Gameplay Programming Assessment.