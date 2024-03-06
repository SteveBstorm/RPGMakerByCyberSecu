using RPGMaker.Models.Monsters;
using RPGMaker.Models.Stuffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Game
{
    public class Partie
    {
        public static List<Equipement> EquipementsEnJeu { get; set; }
        public List<Monstre> Rencontres { get; set; }
        public void InitialiserPartie()
        {
            GenerationEquipement();
            GenerationMonstre();
        }

        private void GenerationEquipement()
        {
            EquipementsEnJeu = new List<Equipement>();
            EquipementsEnJeu.Add(new Arme
            {
                Nom = "Epée courte",
                Prix = 15,
                NbDes = 1,
                NbFace = 6
            });
            EquipementsEnJeu.Add(new Arme
            {
                Nom = "Epée Longue",
                Prix = 25,
                NbDes = 1,
                NbFace = 8
            });
            EquipementsEnJeu.Add(new Arme
            {
                Nom = "Baton",
                Prix = 10,
                NbDes = 1,
                NbFace = 4
            });
            EquipementsEnJeu.Add(new Armure
            {
                Nom = "Armure de cuir",
                Prix = 20,
                ReductionDeDegats = 2
            });
            EquipementsEnJeu.Add(new Armure
            {
                Nom = "Armure de plaque",
                Prix = 50,
                ReductionDeDegats = 5
            });
            EquipementsEnJeu.Add(new Consommable
            {
                Nom = "Potion de soin",
                Prix = 20,
                NbDes = 2,
                NbFace = 4
            });
        }

        private List<Equipement> GenerationLoot()
        {
            Random rnd = new Random();

            List<Equipement> loot = new List<Equipement>();

            int nbLoot = rnd.Next(0, 3);
            for(int i = 0; i < nbLoot; i++)
            {
                
                int obj = rnd.Next(0, EquipementsEnJeu.Count);
                loot.Add(EquipementsEnJeu[obj]);
            }
            return loot;
        }

        private void GenerationMonstre()
        {
            Rencontres = new List<Monstre>();

            Random rng = new Random();

            for (int i = 0; i < 10; i++)
            {
                Monstre m;
                switch (rng.Next(1, 7))
                {
                    case 1:
                    case 2:
                    case 3:
                        m = new Goblin();
                        //m.Creation();
                        ((Goblin)m).Inventaire = GenerationLoot();
                        Rencontres.Add(m);
                        break;
                    case 4:
                    case 5:
                        m = new Loup();
                        //m.Creation();
                        Rencontres.Add(m);
                        break;
                    case 6:
                        m = new Orc();
                        //m.Creation();
                        ((Orc)m).Inventaire = GenerationLoot();
                        Rencontres.Add(m);
                        break;
                }
            }
        }

        public void AfficherRencontres()
        {
            foreach(Monstre m in Rencontres)
            {
                switch (m)
                {
                    case Goblin gob: 
                        gob.ShowCharacterProfile();
                        gob.CoupDeMasse();
                        foreach(Equipement e in gob.Inventaire)
                        {
                            Console.WriteLine(e.Nom);
                        }
                        break;
                    case Loup loup:
                        loup.ShowCharacterProfile();
                        loup.Morsure();
                        loup.Hurlement();
                        break;
                    case Orc orc:
                        orc.ShowCharacterProfile();
                        orc.CoupDeHache();
                        orc.CriDeGuerre();
                        foreach (Equipement e in orc.Inventaire)
                        {
                            Console.WriteLine(e.Nom);
                        }
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine();
            }
        }
    }
}
