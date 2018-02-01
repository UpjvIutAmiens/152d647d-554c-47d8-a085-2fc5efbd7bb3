using System;
using System.ComponentModel.Design.Serialization;

namespace Commande
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration de la référence l1 capable
            // de pointer vers un objet LigneCmd
            LigneCmd l1;

            // Création d'un objet LigneCmd
            // référencé par l1
            l1 = new LigneCmd();

            l1.designation = "Gomme";
            l1.PrixUnitaire = 1.2;
            l1.Quantite = 10;

            LigneCmd l2 = new LigneCmd()
            {
                designation = "Crayon",
                PrixUnitaire = 0.3,
                Quantite = 50
            };

            LigneCmd l3 = new LigneCmd();

            l3.designation = "Bureau";
            l3.PrixUnitaire = 1000;
            l3.Quantite = -100;

            Console.WriteLine(l1.Description());
            Console.WriteLine(l2.Description());
            Console.WriteLine(l3.Description());
        }

    }
}
