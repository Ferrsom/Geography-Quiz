using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        private Country CorrectCountry;
        private List<Country> PossibleCountries;

        public Country CorrectCountry1 { get => CorrectCountry; set => CorrectCountry = value; }
        public List<Country> PossibleCountries1 { get => PossibleCountries; set => PossibleCountries = value; }

        public Question(Country cc, List<Country> lc)
        {
            CorrectCountry = cc;
            PossibleCountries = lc;
        }
    }
}
