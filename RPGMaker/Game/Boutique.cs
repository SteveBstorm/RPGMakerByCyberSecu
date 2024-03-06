using RPGMaker.Models.Characters;
using RPGMaker.Models.Stuffs;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Game
{
    public class Boutique
    {
        private Personnage _joueur;
       

        /// <summary>
        /// Le joueur entre dans la boutique, 
        /// </summary>
        public void EntrerDansLaBoutique(Personnage joueur)
        {
            _joueur = joueur;
            bool continuer = true;
            while (continuer)
            {
               continuer = Menu();
            }
            _joueur.AfficherInventaire();
        }

        /// <summary>
        /// Méthode menu permettant de faire un choix entre vente et achat
        /// méthodes appelées via le switch case
        /// </summary>
        /// <param name="x">Correspont au parametre attendu</param>
        private bool Menu()
        {
            int choix = 0;
            while(choix <1 || choix > 3)
            {
                Console.Clear();
                Console.WriteLine($"Que voulez vous faire de vos {_joueur.Or} Po ? ");
                Console.WriteLine("1 - Acheter");
                Console.WriteLine("2 - Vendre");
                Console.WriteLine("3 - Quitter");
                choix = int.Parse(Console.ReadLine());
            }

            switch (choix)
            {
                case 1: Acheter();
                    break;
                case 2: if (_joueur.Inventaire.Count > 0) Vendre();
                    else {
                        Console.WriteLine("Va farmer t'as rien pour moi");
                        Console.ReadLine();
                            };
                    break;
                case 3:
                    return false;
                    break;
                
            }
            return true;
        }

        private void Acheter()
        {
            int counter = 1;
            Console.WriteLine("Faites votre choix : ");
            int choix = 0;
            foreach (Equipement item in Partie.EquipementsEnJeu)
            {
                Console.WriteLine($"{counter++} - {item.Nom} : {item.Prix} Po");
            }
            choix = int.Parse(Console.ReadLine());

            Equipement achat = Partie.EquipementsEnJeu[choix-1];

            if(_joueur.Or >= achat.Prix)
            {
                _joueur.Inventaire.Add(achat);
                _joueur.Or -= achat.Prix;
                Console.WriteLine($"Vous avez acheté {achat.Nom}");
            }
            else
            {
                Console.WriteLine("Vous êtes trop pauvre pour cet achat !!!");
                Console.ReadLine();
            }
        }

        private void Vendre()
        {
            Console.WriteLine("Quel item voulez vous vendre ?");
            int choix, counter = 0;
            foreach(Equipement item in _joueur.Inventaire)
            {
                Console.WriteLine($"{++counter} - {item.Nom} : {item.Prix / 2} Po");
            }

            choix = int.Parse(Console.ReadLine());

            Equipement vente = _joueur.Inventaire[choix-1];

            //_joueur.Inventaire.RemoveAt(choix - 1);
            _joueur.Inventaire.Remove(vente);
            _joueur.Or += vente.Prix / 2;
        }
    }
}
