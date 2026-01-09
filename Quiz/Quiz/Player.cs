using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Player
    {
        private int pID;
        private string Name;

        public int pID1 { get => pID; set => pID = value; }
        public string Name1 { get => Name; set => Name = value; }

        public Player(int id, string nm)
        {
            pID = id;
            Name = nm;
        }
    }
}
