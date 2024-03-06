using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Tools
{
    public static class GameTools
    {
        public static int GetBonus(int caracteristique)
        {
            if (caracteristique < 10) return -1;
            if (caracteristique < 13) return 0;
            if (caracteristique < 16) return 1;
            if (caracteristique < 19) return 2;
            if (caracteristique < 22) return 3;
            else return 4;
        }
    }
}
