using RPGMaker.Models.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Game
{
    public class Partie
    {
        public List<Monstre> Rencontres { get; set; }
        public void InitialiserPartie()
        {
            Rencontres = new List<Monstre>();
        
            Random rng = new Random();

            for(int i = 0; i < 10;  i++)
            {
                Monstre m;
                switch(rng.Next(1, 7))
                {
                    case 1:
                    case 2:
                    case 3:
                        m = new Goblin();
                        m.Creation();
                        Rencontres.Add(m);
                        break;
                    case 4:
                    case 5:
                        m = new Loup();
                        m.Creation();
                        Rencontres.Add(m);
                        break;
                    case 6:
                        m = new Orc();
                        m.Creation();
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
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine();
            }
        }
    }
}
