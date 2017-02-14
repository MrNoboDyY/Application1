using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {            
            AfficherBienvenue();
            DireBonjour("pierre", 36);
            DireBonjour("guyso", 54);

            double valeur = LongueurHypothenuse(1, 3);
            Console.WriteLine("le premier résultat est : " + valeur);
            valeur = LongueurHypothenuse(10, 10);
            Console.WriteLine("le deuxieme résultat est : " + valeur);


            /* les tableaux en C# */
            string[] jours = new string[]
            {
            "lundi","mardi","mercredi","jeudi","vendredi","samedi","dimanche"
            };
            /*Array.Sort(jours);*/
            Console.WriteLine("----------------------" + Environment.NewLine);

            for (int i = 0; i < jours.Length; i++)
            {
                Console.WriteLine(jours[i]);
                Console.WriteLine("----------------------" + Environment.NewLine);

            };

            /* les Lists */
            List<int> chiffres = new List<int>();//creation de la list//
            chiffres.Add(9);//chiffres contient 9
            chiffres.Add(7);//chiffres contient 7
            chiffres.Add(12);//chiffres contient 12

            chiffres.RemoveAt(1);//chiffres contient 9,12

            foreach(int chiffre in chiffres){
                Console.WriteLine(chiffre);
            }


        }

        /* creation d'une methode */
        static void AfficherBienvenue()
        {
            Console.WriteLine("premiere methode en C#...");            
            Console.WriteLine("\nWelcome to C# world");
            Console.WriteLine("----------------------" + Environment.NewLine);
        }


        /* creation d'une methode */
        static void DireBonjour(string nom,int age)
        {
            Console.WriteLine("bonjour  je suis   " + nom + " et ");            
            Console.WriteLine("j'ai =>>  " + age + "ans");
            Console.WriteLine("**********************************");
        }

        /* retour de methode calculant la recineCarrée */
        static double LongueurHypothenuse(double e,double f)
        {
            double sommeDesCarres = e * e + f * f;
            double resultat = Math.Sqrt(sommeDesCarres);
            return resultat;
        }

        
    }
}
