using Newtonsoft.Json;
using RPGMaker.Models.Characters;
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
    joueur.Creation();

    joueur.ShowCharacterProfile();
}

if(joueur is Guerrier)
{
    ((Guerrier)joueur).CriDeGuerre() ;
}

if(joueur is Mage)
{
    Mage j = (Mage)joueur;
}

if(joueur is Pretre)
{

}

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
