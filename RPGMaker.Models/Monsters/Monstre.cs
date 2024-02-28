using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Monsters
{
    public class Monstre
    {
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

        public void Creation()
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
    }
}
