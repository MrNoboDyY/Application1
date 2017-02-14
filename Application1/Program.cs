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
            /*Tp avec enum 
            Le but est de créer une petite application qui affiche un message différent en fonction du nom de l’utilisateur et du moment de la journée:
            Bonjour XXX pour la tranche horaire 9h <-> 18h, les lundi, mardi, mercredi, jeudi et vendredi
            Bonsoir XXX pour la tranche horaire 18h <-> 9h, les lundi, mardi, mercredi, jeudi
            Bon week-end XXX pour la tranche horaire vendredi 18h <->lundi 9h*/

            if(DateTime.Now.DayOfWeek==DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)//samedi ou dimanche 
            {
                AfficherBonWeekEnd();//c'est le weekend
            }
            else
            {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9)//lundi matin
                {
                    AfficherBonWeekEnd();
                }
                else
                {
                    if(DateTime.Now.Hour >=9 && DateTime.Now.Hour < 18)//c'est la journée entre 9h et 17h
                    {
                        AfficherBonjour();
                    }
                    else
                    {if(DateTime.Now.Hour>=18 && DateTime.Now.DayOfWeek == DayOfWeek.Friday)//en soirée et veille de weekend
                        {
                            AfficherBonWeekEnd();
                        }
                    else
                        {
                            AfficherBonsoir();
                        }
                    }
                }
            }

            /* les Boucles*/
            /* Boucle For */
            string[] jours = new string[]//List<string> jours = new List<string>() + jours.Add("Mardi")
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

            /*Boucle ForEach */           
            foreach(string jour in jours)
            {
                Console.WriteLine(jour);
            }







            /*Console.WriteLine(DateTime.Now);//affichage de la date et de l'heure

            AfficherBienvenue();
            DireBonjour("pierre", 36);
            DireBonjour("guyso", 54);

            double valeur = LongueurHypothenuse(1, 3);
            Console.WriteLine("le premier résultat est : " + valeur);
            valeur = LongueurHypothenuse(10, 10);
            Console.WriteLine("le deuxieme résultat est : " + valeur);


            /* les tableaux en C# */
            /* string[] jours = new string[]//List<string> jours = new List<string>() + jours.Add("Mardi")
             {
             "lundi","mardi","mercredi","jeudi","vendredi","samedi","dimanche"
             };
             /*Array.Sort(jours);*/
            /* Console.WriteLine("----------------------" + Environment.NewLine);

             for (int i = 0; i < jours.Length; i++)
             {
                 Console.WriteLine(jours[i]);
                 Console.WriteLine("----------------------" + Environment.NewLine);

             };

             /* les Lists */
            /* List<int> chiffres = new List<int>();//creation de la list//
             chiffres.Add(9);//chiffres contient 9
             chiffres.Add(7);//chiffres contient 7
             chiffres.Add(12);//chiffres contient 12

             chiffres.RemoveAt(1);//chiffres contient 9,12

             foreach(int chiffre in chiffres){//pour chaque chiffre de la list chiffres
                 Console.WriteLine(chiffre);
             }


         */
        }


        /* Methodes Afficher */
        static void AfficherBonWeekEnd()
        {
            Console.WriteLine("Bon Weekend " + Environment.UserName);
        }


        static void AfficherBonjour()
        {
            Console.WriteLine("Bonjour " + Environment.UserName);
        }


        static void AfficherBonsoir()
        {
            Console.WriteLine("Bonsoir " + Environment.UserName);
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>


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

        //les Enumérations = enum 
        enum Jrs
        {
            lundi,
            mardi,
            mercredi,
            jeudi,
            vendredi,
            samedi,
            dimanche
        }
    }
}
