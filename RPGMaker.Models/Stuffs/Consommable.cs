using RPGMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Stuffs
{
    public class Consommable : Equipement
    {
        public int NbDes { get; set; }
        public int NbFace { get; set; }
        public int Effet() 
        {
            return Des.Jet(NbDes, NbFace);
        }
    }
}
