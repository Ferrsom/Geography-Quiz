using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Continent
    {
        //Aufgrund von Zeitmangel wird diese Klasse in der App nicht wirklich genutzt.

        private int coID;
        private string Name;

        public int coID1 { get => coID; set => coID = value; }
        public string Name1 { get => Name; set => Name = value; }

        public Continent(int id, string nm)
        {
            coID = id;
            Name = nm;
        }
    }
}
