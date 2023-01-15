using System;

namespace TicTacToe
{
    class Program
    {
        static int[] board = new int[9]; // Tells that the board is a part of the main program and not just that section of the static void program.

        static void Main(string[] args)
        {

            /* Represents the game board, 
            The = 0 represents that no one is on or in that square.
            = 1 represent player one's current square,
            = 2 represents player two's current square.
            */


            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }

            
            int userTurn = -1;
            // Declaring userTurn int to make the game playable, and the -1 is the initial value.

            int computerTurn = -1;
            // Declaring computerTurn int to make the computer's turn playable.

            Random rand = new Random();
            // Defining a new random variable.

            while (checkForWinner() == 0)
            {

                while (userTurn == -1 || board[userTurn] != 0)
                {
                    Console.WriteLine("Please enter a number from 0 to 8.");
                    userTurn = int.Parse(Console.ReadLine());
                    /* Ask the user for their input, they will write it in the console and press enter to get the value. 
                       int.parse convert the string to an integer value that can be used. 
                    */

                    Console.WriteLine("The answer you gave was " + userTurn);
                    // This will tell what the user's given number was.
                }

                // Don't allow the player to choose an already selected spot.

                board[userTurn] = 1;
                // = 1, assumes it is player 1.


                // Don't allow the computer pick an invalid number.
                while (computerTurn == -1 || board[computerTurn] != 0)
                {
                    computerTurn = rand.Next(8);
                    // Tells the computer to pick a random number from 0 through 8. 

                    Console.WriteLine("Computer chooses " + computerTurn);
                    // Tells the game that it is the computer's turn.
                }

                board[computerTurn] = 2;
                // Shows on the board that player 2 (O) has selected a spot.

                printBoard();
                // Shows the updated move that was played. 
            }

            // Winner message for either the player or the computer.
            Console.WriteLine("Player " + checkForWinner() + " won the game!");


        }

        /* This is here to check for a winner, return a 0 if no one wins! */
        private static int checkForWinner()
        {
            // top row across win.
            if (board[0] == board[1] && board[1] == board[2])
            {
                return board[0];
            }

            // second row across win.
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }

            // bottom row across win.
            if (board[6] == board[7] && board[7] == board[8])
            {
                return board[6];
            }

            // first column down win.
            if (board[0] == board[3] && board[3] == board[6])
            {
                return board[0];
            }

            // second column down win.
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }

            // third column down win.
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }

            // first diagonal win.
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }

            // second diagonal win.
            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }

            return 0;
        }

        private static void printBoard()
        {
            /* This will now contain our for loop code that houses the game board and player information */

            for (int i = 0; i < 9; i++)

            // i will be our starting variable. 
            {
                // Console.WriteLine("Square " + i + "contains " + board[i]); // <-- this is here to print our board as a single line output, doesn't look good!



                /* Now we will print this out to a board, either an X or an O for each square. */
                /* 0 means no one is in the square, and 1 means player 1 (X) is in the square, 2 means player 2 (O) */

                // == check to see if it equals that value, = this will be the new value no questions asked! 

                if (board[i] == 0)
                {
                    Console.Write("."); // This period is here if no one has claimed that square.
                }

                if (board[i] == 1)
                {
                    Console.Write("X"); // This X is here if Player 1 has claimed that square.
                }
                if (board[i] == 2)
                {
                    Console.Write("O"); // This O is here if Player 2 has claimed that square.
                }

                // After the third square print a new line.
                /* Count begins as 0,1,2, this would equal our three numbers, as well as 5, and 8. */

                if (i == 2 || i == 5 || i == 8) // if our i is at the 3rd final spot on the board, we want to start a new line.  // || = or. 
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
