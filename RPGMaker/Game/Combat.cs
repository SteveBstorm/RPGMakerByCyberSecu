using RPGMaker.Models;
using RPGMaker.Models.Characters;
using RPGMaker.Models.Monsters;
using RPGMaker.Models.Stuffs;
using RPGMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Game
{
    public class Combat
    {
        private Personnage _joueur;
        private Monstre _monstre;

        public Combat(Personnage joueur, Monstre monstre)
        {
            _joueur = joueur;
            _monstre = monstre;
        }

        private Arme ChoixArme()
        {
            Console.WriteLine("Choisissez l'arme à utiliser : ");
            //IEnumerable<Equipement> armes = _joueur.Inventaire.Where(equipement => equipement is Arme).ToList();

            List<Arme> armes = new List<Arme>();
            foreach(Equipement e in _joueur.Inventaire)
            {
                if(e is Arme)
                {
                    armes.Add((Arme)e);
                }
            }

            for (int i = 0; i < armes.Count; i++)
            {
                Console.WriteLine($"{i+1} - {armes[i].Nom}");
            }
            int choix = int.Parse(Console.ReadLine());
            return armes[choix - 1];
        }

        private int CalculReduction()
        {
            List<Armure> armures = new List<Armure>();
            foreach(Equipement item in _joueur.Inventaire)
            {
                if(item is Armure)
                {
                    armures.Add((Armure)item);
                }
            }

            return armures.Max(armure => armure.ReductionDeDegats);
        }

        public bool DebuterCombat()
        {
            Entite attaquant = _joueur;
            while(_joueur.PV > 0 && _monstre.PV > 0) 
            {
                Arme arme = null;
                if (attaquant is Personnage)
                {
                    arme = ChoixArme();
                    int degat = arme.Degat() + GameTools.GetBonus(_joueur.Force);
                    _monstre.PV -= degat;
                    Console.WriteLine($"{_joueur.Nom} a fait {degat} avec son {arme.Nom}");
                    attaquant = _monstre;
                }
                else
                {
                    int degat = _monstre.Degat() + GameTools.GetBonus(_monstre.Force) - CalculReduction();
                    degat = (degat > 0) ? degat : 0;
                    _joueur.PV -= degat;
                    Console.WriteLine($"Le monstre a fait {degat}");
                    attaquant = _joueur;
                }

                Console.WriteLine($"Pv de {_joueur.Nom} : {_joueur.PV}");
                Console.WriteLine($"Pv du monstre : {_monstre.PV}");
            }

            if(_monstre.PV <= 0 && _monstre is IInventaire)
            {
                switch (_monstre)
                {
                    case Goblin g: 
                        if(g.Inventaire.Count > 0)
                            _joueur.Inventaire.AddRange(g.Inventaire);
                        break;
                    case Orc o: 
                        if(o.Inventaire.Count > 0)
                            _joueur.Inventaire.AddRange(o.Inventaire);
                        break;
                }
            }
            //if(_monstre.PV <= 0)
            //{
            //    return true;
            //}
            //return false;

            return _monstre.PV <= 0;
        }
    }
}
