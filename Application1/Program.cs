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
            /* couleurs dans la console 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("jaune");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("rouge");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("rose_vif");*/
  /*================================================================================*/
            /* récupération des parametre de la ligne de commande*/
            /* Deboguer ===>> Proprietes 
            foreach (string parametre in args)
            {
                Console.WriteLine(parametre);
            };*/
        /*==========================================================================*/   

            /* Déplacer du text / dessin
            int i = 0;
            int j = 0;
            int largeur = 21;
            int hauteur = 4;
            Console.WriteLine(@"      .--------.");
            Console.WriteLine(@" ____/_____|___ \___");
            Console.WriteLine(@"O    _   - |   _   ,*");
            Console.WriteLine(@" '--(_)-------(_)--'");
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (i > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i - 1, j);
                            i--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (i < Console.WindowWidth - largeur)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i + 1, j);
                            i++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (j > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i, j - 1);
                            j--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        Console.MoveBufferArea(i, j, largeur, hauteur, i, j + 1);
                        j++;
                        break;
                }
                if (info.Key == ConsoleKey.Q)
                    break;
            }*/
        
        /*=====================================================================*/

            /* Trouver le nombre myster en quelques coups   
        int valATrouver = new Random().Next(0, 100);
            int nbreDeCoups = 0;
            bool trouve = false;
            Console.WriteLine("saisir un nbre entre 0 et 100 exclu");
            while (!trouve)
            {
                string nbreSaisi = Console.ReadLine();
                int valSaisie;
                if (int.TryParse(nbreSaisi, out valSaisie))
                {
                    if (valSaisie == valATrouver)
                        trouve = true;
                    else
                    {
                        if (valSaisie < valATrouver)
                            Console.WriteLine("trop petit ...");
                        else
                            Console.WriteLine("trop grand");
                    }
                    nbreDeCoups++;
                }
                else
                    Console.WriteLine("la valeur saisie est incorrect");
            }
            Console.WriteLine("vous avez trouvé le nombre mystere en  "  + nbreDeCoups +  "coup(s)");*/

            
   /*================================================================================================================*/         
                 
            /* Console.WriteLine("voulez-vous continuer (O/N) ??");
             ConsoleKeyInfo clav = Console.ReadKey(true);
             if (clav.Key == ConsoleKey.O)
             {
                 Console.WriteLine("on continue !!!!!");
             }
             else
             {
                 Console.WriteLine("on arrete tout :((");
             }*/


            /*=======================================================================================================================================================*/
            /*Tp avec enum 
            Le but est de créer une petite application qui affiche un message différent en fonction du nom de l’utilisateur et du moment de la journée:
            Bonjour XXX pour la tranche horaire 9h <-> 18h, les lundi, mardi, mercredi, jeudi et vendredi
            Bonsoir XXX pour la tranche horaire 18h <-> 9h, les lundi, mardi, mercredi, jeudi
            Bon week-end XXX pour la tranche horaire vendredi 18h <->lundi 9h

            if (DateTime.Now.DayOfWeek==DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)//samedi ou dimanche 
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
            }*/

            /*======================================================================================================================*/

            /* les Boucles*/
            /* Boucle For 
            string[] jours = new string[]//List<string> jours = new List<string>() + jours.Add("Mardi")
             {
             "lundi","mardi","mercredi","jeudi","vendredi","samedi","dimanche"
             };
            /*Array.Sort(jours);
             Console.WriteLine("----------------------" + Environment.NewLine);

             for (int i = 0; i < jours.Length; i++)
             {
                 Console.WriteLine(jours[i]);
                 Console.WriteLine("----------------------" + Environment.NewLine);

             };

            /*Boucle ForEach            
            foreach(string jour in jours)
            {
                Console.WriteLine(jour);
            };*/
            /*================================================================================================================================================*/
            /* Lecture clavier en C#  */
            /*Console.ReadLine();//lecture au clavier de ce que tape le client
            Console.WriteLine("quel est votre âge ??");
            string age1 = Console.ReadLine();
            Console.WriteLine("vous avez : " + age1 + "ans");*/


            /* bool ageValid = false;
             int age = -1;
             while (!ageValid)
             {
                 Console.WriteLine("entrez votre age");
                 string saisie = Console.ReadLine();
                 if (int.TryParse(saisie, out age))
                     ageValid = true;
                 else
                 {
                     ageValid = false;
                     Console.WriteLine("l'age saisi est incorrect...!");
                 }
             }
             Console.WriteLine("votre age est : " + age);*/


            /*==========================================================================*/

            /* lire un caractere tapé au clavier */
            /*Console.WriteLine("taper un caractere avant de commencer");
            Console.ReadKey(true);
            int total = 0;
            for(int i = 0; i < 100; i++)
            {
                total += i;
            }
            Console.WriteLine(total);*/




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

            //Console.WriteLine(SommeIntersection());
        }//fin du main !!!!!!!!!!!




/*==============================================================================================================*/



        /*Tp avec Boucles
             Le but de ce TP va être de créer 3 méthodes.
             CalculSommeEntiers , CalculMoyenne, SommeIntersection
             On commence par créer nos deux listes de multiples. Comme je vous avais conseillé, j’utilise une boucle for qui commence à trois avec un incrément de 3. Comme ça, je suis sûr d’avoir tous les multiples de 3 dans ma liste. C’est le même principe pour les multiples de 5, sachant que dans les deux cas, la condition de sortie est quand l’indice est supérieur à 100.
             Ensuite, j’ai mes deux boucles imbriquées où je compare les deux valeurs et si elles sont égales, je rajoute la valeur à la somme globale que je renvoie en fin de méthode.
             Pour bien comprendre ce qu’il se passe dans les boucles imbriquées, il faut comprendre que nous allons parcourir une unique fois la liste multiplesDe3 mais que nous allons parcourir autant de fois la liste multipleDe5 qu’il y a d’éléments dans la liste multipleDe3, c’est-à-dire 33 fois.
             Ce n’est sans doute pas facile de le concevoir dès le début, mais pour vous aider, vous pouvez essayer de vous faire l’algorithme dans la tête :
             On rentre dans la boucle qui parcoure la liste multiplesDe3
             m3 vaut 3
             On rentre dans la boucle qui parcoure la liste multiplesDe5
             m5 vaut 5
             On compare 3 à 5, ils sont différents
             On passe à l’itération suivante de la liste multiplesDe5
             m5 vaut 10
             On compare 3 à 10, ils sont différents
             Etc … jusqu’à ce qu’on ait fini de parcourir la liste des multiplesDe5
             On passe à l’itération suivante de la liste multiplesDe3
             m3 vaut 6
             On rentre dans la boucle qui parcoure la liste multiplesDe5
             m5 vaut 5
             On compare 6 à 5, ils sont différents
             On passe à l’itération suivante de la liste multiplesDe5
             Etc …
             

        static int CalculerSommeEntiers(int bornMin,int borneMax)
        {
            int resultat = 0;
            for (int i = bornMin ; i <= borneMax ; i++) 
            {
                resultat += i;
            }
            return resultat;
        }


        static double CalculMoyenne(List<double> liste)
        {
            double somme = 0;
            foreach(double valeur in liste)
            {
                somme += valeur;
            }
            return somme/liste.Count;
        }

        static int SommeIntersection()
        {
            List<int> multipleDe3 = new List<int>();//creation list pour m3
            List<int> multipleDe5 = new List<int>();//creation list pour m5

            for(int i = 3; i<=20; i += 3)//incrementation a 3 jusqu'à 100
            {
                multipleDe3.Add(i);//peuplement de la list
            }
            for(int i = 5; i<=20; i += 5)//incrementation a 5 jusqu'à 100
            {
                multipleDe5.Add(i);//peuplement de la list
            }

            int somme = 0;
            foreach(int m3 in multipleDe3)//on rentre dans les multiples de 3
            {
                foreach(int m5 in multipleDe5)//on rentre dans les multiples de 5
                {
                    if (m3 == m5)//comparaison des m3 et m5
                        somme += m3;//affectation a la variable somme
                }
            }
            return somme;//affichage de la variable somme
        }

        
        /* Methodes Afficher 
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
        }*/

        /*=========================================================================================*/
        
        /*=========================================================================================*/


        /* creation d'une methode 
        static void AfficherBienvenue()
        {
            Console.WriteLine("premiere methode en C#...");            
            Console.WriteLine("\nWelcome to C# world");
            Console.WriteLine("----------------------" + Environment.NewLine);
        }


        /* creation d'une methode 
        static void DireBonjour(string nom,int age)
        {
            Console.WriteLine("bonjour  je suis   " + nom + " et ");            
            Console.WriteLine("j'ai =>>  " + age + "ans");
            Console.WriteLine("**********************************");
        }

        /* retour de methode calculant la recineCarrée 
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
        }*/
        
    }


}
