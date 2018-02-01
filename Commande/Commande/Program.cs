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
            l1 = new LigneCmd("Gomme", 1.2, 10);

            LigneCmd l2 = new LigneCmd(
                quantite: 50,
                designation : "Crayon",
                prixUnitaire : 0.3
            );

            LigneCmd l3 = new LigneCmd("Bureau", 1000, 100);

            Console.WriteLine(l1.Description());
            Console.WriteLine(l2.Description());
            Console.WriteLine(l3.Description());
        }

    }
}
