# Guessing Game

This is a simple guessing game application developed in C# using Visual Studio. In this game, players choose the difficulty level (easy, medium, or hard) and are given a certain amount of time to guess a randomly generated number within a specified range.

## Features

1. **Difficulty Levels:** Players can choose between easy, medium, and hard difficulty levels, each with a different time limit for guessing the number.
   
2. **Customizable Range:** Players can set the minimum and maximum values for the range within which the randomly generated number will be selected.

3. **Timer:** A timer is displayed during the game, counting down the remaining time for guessing the number.

## Installation

1. Clone this repository to your local machine.
   
2. Open the project in Visual Studio.

3. Build and run the project.

## Usage

1. Launch the application.

2. Set the minimum and maximum values for the range of the randomly generated number.

3. Choose the desired difficulty level (easy, medium, or hard).

4. Click the "Start Game" button to begin.

5. Enter your guess in the text field and click the "Guess" button.

6. Depending on your guess, you'll receive hints to guess higher or lower if needed.

7. Try to guess the number within the given time limit.

8. If you guess the number correctly within the time limit, you win the game. Otherwise, you lose.

## Credits

This guessing game application was created by Yuliya Yafimava.

## Code Structure

The application consists of two forms (`Form1` and `Form2`) and a static class (`Game`) to store game-related data such as time limit and range.

### `Form1`

This form is used to set the minimum and maximum values for the number range and choose the difficulty level. It defines the logic for starting the game and passing the selected parameters to `Form2`.

### `Form2`

This form represents the main game interface. It displays the timer, handles user input for guessing the number, provides hints, and determines the game outcome.

### `Game`

A static class used to store game-related data such as the time limit (`time`) and range (`min` and `max`).
