using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Characters
{
    public class Personnage
    {
        public string Nom { get; set; }

        #region Caractéristiques

        private int _force;

        public virtual int Force
        {
            get { return _force; }
            set { _force = value; }
        }

        private int _endurance;

        public virtual int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }

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


        #endregion

        public void Creation()
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
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            Console.WriteLine($"Intel : {Intelligence} ({_intelligence})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse})");

        }
    }
}
