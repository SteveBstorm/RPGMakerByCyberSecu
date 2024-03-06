using RPGMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models
{
    public abstract class Entite
    {
        /// <summary>
        /// Propriétés partagées entre tout les sous type d'entité (monstre et personnage)
        /// passage de private à protected pour accéder aux _champs dans les classes enfants
        /// </summary>
        protected int _force;

        public virtual int Force
        {
            get { return _force; }
            set { _force = value; }
        }

        protected int _endurance;

        public virtual int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }

       // public int PV { get; set; }

        private int _pv;

        public int PV
        {
            get { return _pv; }
            set { _pv = value; 
                if(_pv > MaxPV) _pv = MaxPV;
            }
        }

        public int MaxPV { get; set; }

        /// <summary>
        /// Déclaration de la méthode abstract Creation pour l'utiliser dans le constructeur
        /// de chaque entité avec la version définie (override) dans la classe enfant
        /// </summary>
        public abstract void Creation();

        public Entite()
        {
            Creation();
            MaxPV = 10 + GameTools.GetBonus(Endurance);
            PV = MaxPV;

        }
    }
}
