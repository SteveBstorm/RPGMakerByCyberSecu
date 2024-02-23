using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Characters
{
    public class Mage
    {
        public string Nom { get; set; }

        #region Caractéristiques

        private int _force;

        public int Force
        {
            get { return _force; }
            set { _force = value; }
        }

        private int _endurance;

        public int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }

        private int _intelligence;

        public int Intelligence
        {
            get { return _intelligence + 4; }
            set { _intelligence = value; }
        }

        private int _sagesse;

        public int Sagesse
        {
            get { return _sagesse + 2; }
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
    }
}
