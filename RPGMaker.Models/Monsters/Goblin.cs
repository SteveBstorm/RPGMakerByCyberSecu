using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Monsters
{
    public class Goblin : Monstre
    {
        public override int Force { get => base.Force - 1; set => base.Force = value; }
    
        public void CoupDeMasse()
        {
            Console.WriteLine("Moi taper toi avec gros bout de bois");
        }
    }
}
