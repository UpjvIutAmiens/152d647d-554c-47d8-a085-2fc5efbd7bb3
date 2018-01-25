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
                affichage +=
                    String.Format("{0,2} x {1} = {2:00}",
                    i, // element 0
                    multiple, // element 1
                    i * multiple //element 2
                    );
                affichage += "\n";
            }

            Console.WriteLine(affichage);
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
