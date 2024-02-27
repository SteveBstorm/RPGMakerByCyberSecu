using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Monsters
{
    public class Loup : Monstre
    {
        public override int Force { get => base.Force + 2; set => base.Force = value; }
        public override int Endurance { get => base.Endurance + 1; set => base.Endurance = value; }
    
        public void Morsure()
        {
            Console.WriteLine("Coup de dent");
        }

        public void Hurlement()
        {
            Console.WriteLine("Hurle à la mort");
        }
    }
}
