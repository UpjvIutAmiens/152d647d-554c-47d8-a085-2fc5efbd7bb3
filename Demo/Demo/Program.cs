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
                // Interpolated String (à partir de C#v6)
                int resultat = i * multiple;
                affichage += $"{i,2} x {multiple} = {resultat:00}";
                affichage += "\n";
            }

            Console.WriteLine(affichage);
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
