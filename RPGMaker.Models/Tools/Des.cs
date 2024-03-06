using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Tools
{
    public class Des
    {
        public static int Jet(int nbDes, int nbFace)
        {
            Random rnd = new Random();
            int result = 0;
            for (int i = 0; i < nbDes; i++)
            {
               result += rnd.Next(1, nbFace + 1);
            }
            return result;
        }
    }
}
