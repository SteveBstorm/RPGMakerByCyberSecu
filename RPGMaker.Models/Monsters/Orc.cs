using RPGMaker.Models.Stuffs;
using RPGMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Monsters
{
    public class Orc : Monstre, IInventaire
    {
        public override int Force { get => base.Force + 3; set => base.Force = value; }
        public override int Endurance { get => base.Endurance +2; set => base.Endurance = value; }

        public List<Equipement> Inventaire { get; set; }

        public void CoupDeHache()
        {
            Console.WriteLine("Coup de Hache");
        }    

        public void CriDeGuerre()
        {
            Console.WriteLine("Encore du travail !!! :'(");
        }

        public override int Degat()
        {
            return Des.Jet(1, 8);
        }
    }
}
