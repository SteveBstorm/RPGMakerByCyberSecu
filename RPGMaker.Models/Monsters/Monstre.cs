using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Monsters
{
    public abstract class Monstre : Entite
    {
		

        public override void Creation()
        {
            Random r = new Random();
            Force = r.Next(10, 21);
            Endurance = r.Next(10, 21);
        }

        public void ShowCharacterProfile()
        {

            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");

        }

        public abstract int Degat();
    }
}
