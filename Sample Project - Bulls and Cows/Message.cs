using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullsAndCows
{
    class Message
    {
        public const string GREETING_MESSAGE = "Welcome to “Bulls and Cows” game." +
            "Please try to guess my secret 4-digit number." +
            "Use 'top' to view the top scoreboard, 'restart'" +
            "to start a new game and 'help'" +
            " to cheat and 'exit' to quit the game.";
        public const string ENTER_GUESS_ORcOMMAND = "Enter your guess or command: ";

        public const string ENTERED_INVALID_NUMBER = "You have entered invalid number!";
        public const string WRONG_NUMBER ="Wrong number!";
        public const string CONGRATULATIONS_NO_CHEATS = "Congratulations! You guessed" +
                " the secret number in {0} attempts.";
        public const string CONGRATULATIONS_WITH_CHEATS =
            "Congratulations! You guessed the" +
                " secret number in {0}" +
                " attempts and {1} cheats.";
    }
}
