using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lastOne.Models
{
    [Serializable]
    public class Game
    {
        public int id { get; set; }
        public int numOfGames { get; set; }
        public int firtPlayerWins { get; set; }
        public bool gamerunning { get; set; }
        public MainBoard mainBoard { get; set; }
        public Move move { get; set; }
        public sideBoard pl1SideBoard { get; set; }
        public sideBoard pl2SideBoard { get; set; }
        public string firstPlayerName { get; set; }
        public string secondPlayerName { get; set; }
        public Game(string firstPlayerName)
        {
            mainBoard = new MainBoard();
            pl1SideBoard = new sideBoard();
            pl2SideBoard = new sideBoard();
            this.firstPlayerName = firstPlayerName;
            move = new Move();
            pl1SideBoard.owner = Players.Player1;
            pl2SideBoard.owner = Players.Player2;
            mainBoard.initDefault();
            numOfGames = 0;
            firtPlayerWins = 0;
            gamerunning = false;
            secondPlayerName = null;
    }
    }
}
