using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixteenStones
{
    internal class SixteenStones
    {
        private int[] board;
        private int turn;
        private int[] players;
        private bool[,] boolBoard;
        private string outputString;
        private bool gameState;


        //START: Constructor(s)
        public SixteenStones()
        {
            this.board = new int[] { 6, 4, 3, 2, 1 };
            this.turn = 1;
            this.players = new int[] { 2, 1 };
            this.ConfigureBoolBoard();
            this.gameState = true;
            this.outputString = "Initialized.";
        }
        //END: Constructor(s)

        //START: Getter(s)
        public int[] GetBoard()
        {
            return this.board;
        }
        public int GetTurn()
        {
            return this.turn;
        }
        public int GetTurnPlayer()
        {
            return this.players[this.turn % 2];
        }
        public bool[,] GetBoolBoard()
        {
            return this.boolBoard;
        }
        public string GetOutputString()
        {
            return this.outputString;
        }
        public bool GetGameState()
        {
            return this.gameState;
        }
        //END: Getter(s)

        //START: Public function(s)
        public bool Move(int row, int stones)
        {
            int index = row - 1;
            if (index < 0 || index >= this.board.Length)
            {
                this.outputString = "Entered row does not exist.";
                return false;
            }
            else
            {
                if (stones == 0)
                {
                    this.outputString = "You must take at least one stone.";
                    return false;
                }
                else if (stones < 0)
                {
                    this.outputString = "Negative stones do not exist.";
                    return false;
                }
                else if (stones > this.board[index])
                {
                    this.outputString = "You cannot take that many stones from the selected row.";
                    return false;
                }
                else
                {
                    //Predict the move's game state:
                    int[] temp = new int[5];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = this.board[i];
                    }
                    temp[index] -= stones;

                    int boardSum = 0;
                    foreach (int value in temp)
                    {
                        boardSum += value;
                    }
                    if (boardSum <= 0)
                    {
                        this.outputString = "You must leave at least one stone on the board.";
                        return false;
                    }
                    else
                    {//All failsafe checks passed!
                        this.board[index] -= stones; //Execute play.
                        this.ConfigureBoolBoard(); //Configure the boolean board.
                        if (boardSum > 1)
                        {
                            this.turn++;
                        }
                        else
                        {
                            this.gameState = false;
                        }
                        this.outputString = "Successful turn!";
                        return true;
                    }
                }
            }
        }//END Function: Move(int, int)
         //END: Public functions(s)

        //START: Private function(s)
        private void ConfigureBoolBoard()
        {
            this.boolBoard = new bool[5, 6];

            //declare temp array & copy board contents to it.
            int[] temp = new int[this.board.Length];
            //WriteLine("Copying board...");
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = this.board[i];
            }
            //WriteLine("Board copied!");

            for (int i = 0; i < this.boolBoard.GetLength(0); i++)
            {
                //WriteLine(String.Format("i={0}",i));
                for (int j = 0; j < this.boolBoard.GetLength(1); j++)
                {
                    //WriteLine(String.Format("\tj={0}",j));
                    if (temp[i] > 0)
                    {
                        //WriteLine("Setting boolBoard.");
                        this.boolBoard[i, j] = true;
                        //WriteLine("Decrementing temp array.");
                        --temp[i];
                    }
                    else
                    {
                        this.boolBoard[i, j] = false;
                    }
                }
            }
        }//END Function: ConfigureBoolBoard()
         //END: Private function(s)
    }//END CLASS: SixteenStones
}
