using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Flag
    {
        private int fID;
        private string Name;

        public int fID1 { get => fID; set => fID = value; }
        public string Name1 { get => Name; set => Name = value; }

        public Flag(int id, string nm)
        {
            fID = id;
            Name = nm;
        }
    }
}
