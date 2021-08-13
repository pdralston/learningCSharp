using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        private static string[] boardState;
        private static bool playerOne, winCondition;
        private static int moveCount;
        private const int MAX_MOVES = 9;
        private const string X = " X ", O = " O ";

        public Board()
        {
            boardState = new string[10];
            ResetBoard();
            boardState[0] = "   |";
        }

        public void Play()
        {
            do
            {
                Console.Clear();
                Console.Write(this + $"Player {(playerOne ? "1" : "2")}, please select an available square: ");
                MakeMove();
                CheckWinCondition();
            } while (!winCondition && moveCount < MAX_MOVES);
            PrintResult();
            return;
        }

        public void ResetBoard()
        {
            for (int i = 1; i < boardState.Length; ++i)
            {
                boardState[i] = $" {i} ";
            }
            playerOne = true;
            moveCount = 0;
            winCondition = false;
        }

        private void PrintResult()
        {
            Console.Clear();
            Console.WriteLine(this);
            if (winCondition)
            {
                Console.WriteLine($"Player {(playerOne ? '2' : '1')} Wins!");
            }
            else
            {
                Console.WriteLine("Cats Game!");
            }
        }

        private void MakeMove()
        {
            int move;
            while (!int.TryParse(Console.ReadLine(), out move) || move < 1 || move >= boardState.Length || boardState[move].Equals(X) || boardState[move].Equals(O))
            {
                Console.Write("Invalid Selection, Please try Again: ");
            }
            boardState[move] = playerOne ? X : O;
            ++moveCount;
            playerOne = !playerOne;
        }

        private void CheckWinCondition()
        {
            for (int i = 1; i < boardState.Length; i += 3)
            {
                int columnIndex = 1; 
                if (winCondition) return;
                winCondition = boardState[i].Equals(boardState[i + 1]) && boardState[i].Equals(boardState[i + 2]) //check Rows
                            || boardState[columnIndex].Equals(boardState[columnIndex + 3]) && boardState[columnIndex].Equals(boardState[columnIndex + 6]); //checkColumns
                ++columnIndex;
            }
            winCondition = winCondition || CheckDiaganols();
        }

        private bool CheckDiaganols()
        {
            return boardState[1].Equals(boardState[5]) && boardState[1].Equals(boardState[9])
                || boardState[3].Equals(boardState[5]) && boardState[3].Equals(boardState[7]);
        }
        public override string ToString()
        {
            string returnValue = "",
                   columnBreak = $"{ boardState[0] }{ boardState[0] }\n",
                   rowBreak = "___|___|___\n";
            for (int i = 1; i < boardState.Length; i+=3)
            {
                string row = $"{boardState[i]}|{boardState[i + 1]}|{boardState[i + 2]}\n";
                returnValue += i < 7 ? columnBreak + row + rowBreak : columnBreak + row + columnBreak;
            }
            return returnValue;
        }

    }
}
