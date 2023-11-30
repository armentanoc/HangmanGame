# Hangman Game 🎮

## Project Overview

This is a simple console-based Hangman Game implemented in C#.

## Project Structure

The solution consists of the following components:

- **hangmanGame (Solution):**
  - **hangmanGame.main (Project):**
    - **Game (Folder):**
      - **Display (Class):** Contains the logic for displaying the hanged man.
      - **Gameplay (Class):** Manages the gameplay flow and user interactions.
      - **Word (Class):** Handles word selection, word attempts, and letter tracking.
    - **Person (Folder):**
      - **Player (Class):** Represents the player with methods to handle player information.
    - **Program (Class):** Contains the main method to start the application.

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
