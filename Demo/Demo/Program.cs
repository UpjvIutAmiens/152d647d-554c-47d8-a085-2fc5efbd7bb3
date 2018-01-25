using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afficher la table des 8
            // Concaténation : +
            // Saut de ligne : \n
            const int multiple = 8;
            const int valMax = 10;

            string affichage = "";

            for (int i=0; i<= valMax; i++)
            {
                affichage = affichage + i + " x " + multiple;
                affichage += " = " + (i * multiple);
                affichage += "\n";
            }

            Console.WriteLine(affichage);
            System.Console.WriteLine("Press a key");
            System.Console.ReadKey();
        }
    }
}
