using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Characters
{
    public class Guerrier
    {
        public string Nom { get; set; }

        #region Caractéristiques

        private int _force;

        public int Force
        {
            get { return _force + 3; }
            set { _force = value; }
        }

        private int _endurance;

        public int Endurance
        {
            get { return _endurance + 3; }
            set { _endurance = value; }
        }

        private int _intelligence;

        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        private int _sagesse;

        public int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value; }
        }


        #endregion

        public void Creation()
        {
            Console.Write("Choisissez votre nom : ");
            Nom = Console.ReadLine();

            Random r = new Random();
            Force = r.Next(10, 21);
            Endurance = r.Next(10, 21);
            Intelligence = r.Next(10, 21);
            Sagesse = r.Next(10, 21);
        }

        public void ShowCharacterProfile()
        {
            Console.WriteLine(nameof(Guerrier));
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            Console.WriteLine($"Intel : {Intelligence} ({_intelligence})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse})");
        }
    }
}
