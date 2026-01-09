using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Country
    {
        private int couID;
        private string Name;
        private int flagID;
        private int capitalID;
        private int continentID;
        
        public int couID1 { get => couID; set => couID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int flagID1 { get => flagID; set => flagID = value; }
        public int capitalID1 { get => capitalID; set => capitalID = value; }
        public int continentID1 { get => continentID; set => continentID = value; }

        public Country(int id, string nm, int fid, int caid, int coid)
        {
            couID = id;
            Name = nm;
            flagID = fid;
            capitalID = caid;
            continentID = coid;
        }

    }
}
