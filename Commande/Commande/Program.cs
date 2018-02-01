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
            l1.prixUnitaire = 1.2;
            l1.quantite = 10;

            LigneCmd l2 = new LigneCmd()
            {
                designation = "Crayon",
                prixUnitaire = 0.3,
                quantite = 50
            };

            Console.WriteLine(l1.Description());
            Console.WriteLine(l2.Description());
        }
    }
}
