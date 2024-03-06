using RPGMaker.Models.Stuffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Characters
{
    public abstract class Personnage : Entite, IInventaire
    {
        public string Nom { get; set; }

        public int Or { get; set; }
      
        #region Caractéristiques

        private int _intelligence;

        public virtual int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        private int _sagesse;

        public virtual int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value; }
        }
        public List<Equipement> Inventaire { get; set; }

        public Personnage()
        {
            Or = 100;
            Inventaire = new List<Equipement>();
        }



        #endregion

        public override void Creation()
        {

            Console.Write($"Choisissez votre nom de {this.GetType().Name} : ");
            Nom = Console.ReadLine();

            Random r = new Random();
            Force = r.Next(10, 21);
            Endurance = r.Next(10, 21);
            Intelligence = r.Next(10, 21);
            Sagesse = r.Next(10, 21);
            
        }

        public void ShowCharacterProfile()
        {
            
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"PV : {PV}");
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            Console.WriteLine($"Intel : {Intelligence} ({_intelligence})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse})");

        }

        public void AfficherInventaire()
        {
            foreach(Equipement item in Inventaire)
            {
                Console.WriteLine($"{item.Nom}");
            }
            Console.WriteLine();
            Console.WriteLine($"Vous avez {Or} Po");
        }
    }
}
