using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Game
    {
        private int gID;
        private int Score;
        private int playerID;

        public int gID1 { get => gID; set => gID = value; }
        public int Score1 { get => Score; set => Score = value; }
        public int playerID1 { get => playerID; set => playerID = value; }

        public Game(int id, int sc, int pid)
        {
            gID = id;
            Score = sc;
            playerID = pid;
        }


    }
}
