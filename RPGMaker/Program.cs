using Newtonsoft.Json;
using RPGMaker.Game;
using RPGMaker.Models.Characters;
using RPGMaker.Models.Monsters;
using RPGMaker.Models.Stuffs;
using System.Text.Json.Serialization;



Personnage joueur;

int choix = 0;
while (choix < 1 || choix > 3)
{

    Console.WriteLine("Quelle classe voulez vous jouer ?");
    Console.WriteLine("1. Guerrier");
    Console.WriteLine("2. Mage");
    Console.WriteLine("3. Prêtre");

    choix = int.Parse(Console.ReadLine());
}

switch (choix)
{
    case 1:
        joueur = new Guerrier();
        break;
    case 2:
        joueur = new Mage();
        break;
    case 3:
        joueur = new Pretre();
        break;
    default:
        joueur = null;
        break;
}
if (joueur != null)
{
    //joueur.Creation();

    joueur.ShowCharacterProfile();
}


Partie maGame = new Partie();
maGame.InitialiserPartie();
maGame.AfficherRencontres();

Boutique b = new Boutique();
b.EntrerDansLaBoutique(joueur);

bool PersoEstVivant = true;
int compteurDeRencontre = 0;
while (PersoEstVivant)
{
    

    Console.WriteLine();
    Console.WriteLine($"Que voulez vous faire ? (Vos PV Actuels : {joueur.PV} / {joueur.MaxPV} )");
    Console.WriteLine("1 - Passer au combat suivant");
    Console.WriteLine("2 - Entrer dans la boutique");
    Console.WriteLine("3 - Afficher Inventaire");
    if (joueur.Inventaire.Count(x => x is Consommable) > 0)
        Console.WriteLine("4 - Prendre une potion");
    int choixMenu = int.Parse(Console.ReadLine());

    switch (choixMenu)
    {
        case 1:
                Combat c = new Combat(joueur, maGame.Rencontres[compteurDeRencontre]);
                PersoEstVivant = c.DebuterCombat(); ;
                compteurDeRencontre++;
            break;
        case 2: b.EntrerDansLaBoutique(joueur);
            break;
        case 3: joueur.AfficherInventaire();
            break;
        case 4: joueur.PV += ((Consommable)Partie.EquipementsEnJeu[5]).Effet();
               
            break;

    }
}


////Combat c = new Combat(joueur, maGame.Rencontres[0]);
//if(c.DebuterCombat())
//{
//    Console.WriteLine("Félicitations");
//}
//else
//{
//    Console.WriteLine("t'es mort !!!");
//}

//if(joueur is Guerrier)
//{
//    ((Guerrier)joueur).CriDeGuerre() ;
//}

//if(joueur is Mage)
//{
//    Mage j = (Mage)joueur;
//}

//if(joueur is Pretre)
//{

//}



//Monstre m = new Goblin(); //boxing

//Goblin g = (Goblin)m; //unboxing

//g.CoupDeMasse();

//((Goblin)m).CoupDeMasse();

//List<Personnage> groupe = new List<Personnage>();
//Guerrier g = new Guerrier();
//g.Creation();
//Guerrier g2 = new Guerrier();
//g2.Creation();
//Mage m = new Mage();
//m.Creation();
//Pretre p = new Pretre();
//p.Creation();

//groupe.Add(g);
//groupe.Add(g2);

//groupe.Add(m);

//groupe.Add(p);

//foreach(Personnage perso in groupe)
//{
//    perso.ShowCharacterProfile();
//    switch (perso)
//    {
//        case Guerrier gu:
//            Console.WriteLine($"Le guerrier {gu.Nom} ");
//            gu.CriDeGuerre();
//            break;
//    }
//   // Console.WriteLine(p.GetType().Name);
//}
