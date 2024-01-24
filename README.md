# Hangman Game 🎮

## Project Overview

This is a simple console-based Hangman Game implemented in C#.

## Project Structure

The solution consists of the following components:

**`hangmanGame` (Solution)**
  - **`hangmanGame.main` (Project)**
    - **`Game` (Folder):**
      - **`Display.cs` (Class):** Contains the logic for displaying the hanged man.
      - **`Gameplay.cs` (Class):** Manages the gameplay flow and user interactions.
      - **`Word.cs` (Class):** Handles word selection, word attempts, and letter tracking.
      -  **`WordOptions.cs` (Class):** Centralize the word options dictionary with corresponding themes.
    - **`Person` (Folder)**
      - **`Player.cs` (Class):** Represents the player with methods to handle player information.
    - **`Program.cs` (Class):** Contains the main method to start the application.

## How to Run the Game 🚀

1. Clone the repository to your local machine.
2. Open the solution in your preferred C# IDE (e.g., Visual Studio).
3. Set the `hangmanGame.main` project as the startup project.
4. Run the application.

## Gameplay Instructions 🕹️

1. Enter your name when prompted.
2. The game will randomly select a word, and you need to guess the letters.
3. Enter a letter when prompted.
4. The game will display the word with correct guesses and inform you about incorrect attempts.
5. Keep guessing until you either complete the word or reach the maximum allowed attempts.

Enjoy the game! 🎉

## Demo Video

https://github.com/armentanoc/HangmanGame/assets/88147887/0767ba59-8014-4c77-83d3-c06c76c6490c
