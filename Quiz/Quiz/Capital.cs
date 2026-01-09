using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Capital
    {
        private int caID;
        private string Name;

        public int caID1 { get => caID; set => caID = value; }
        public string Name1 { get => Name; set => Name = value; }

        public Capital(int id, string nm)
        {
            caID = id;
            Name = nm;
        }
    }
}
