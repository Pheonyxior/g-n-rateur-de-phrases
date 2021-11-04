using System;
using System.Collections.Generic;
namespace générateur_de_phrases
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            var sujets = new List<string>          // Déclare une liste de sujets
            {
                "Un squelette ",
                "Une fondue savoyarde ",
                "Un titan ",
                "Luffy ",
                "Saitama ",
                "Le laptop du prof ",
                "Le respect ",
                "The Rock ",
                "Frangipanus ",
                "Un gratin dauphinois ",
                "Un chat ",
                "Un chien ",
                "Un perroquet ",
                "Un pokemon ",
                "Colonel Reyel ",
                "Le capitaine Crochet ",
                "Diablox9 ",
                "Digidix ",
                "Orelsan ",
                "Un deviljho ",
                "Un rathalos ",
                "Une rathian ",
                "Un lagiacrus ",
                "Un Zinogre ",
                "Une bazelgeuse ",
                "Un maître du jiu-jitsu Brésilien "
            };
            var verbes = new List<string>         // Déclare une liste de verbes
            {
                "défonse ",
                "néttoie ",
                "tacle ",
                "fait une clé de bras à ",
                "étrangle ",
                "balance ",
                "lèche ",
                "crache sur ",
                "mange ",
                "t'apportes ",
                "ramasse ",
                "malaxe ",
                "tape sur ",
                "bombarde ",
                "fait une pichenette à ",
                "écoute ",
                "dort sur ",
                "tricotte pour ",
                "chasse ",
                "rap avec ",
                "gratte ",
                "danse avec ",
                "joue avec ",
                "regarde ",
                "glisse sur "
            };
            var compléments = new List<string>     // Déclare une liste de compléments
            {
                "un squelette",
                "une fondue savoyarde",
                "un titan",
                "Luffy",
                "Saitama",
                "le laptop du prof",
                "le respect",
                "Colonel Reyel",
                "le capitaine Crochet",
                "Orelsan",
                "un deviljho",
                "une bazelgeuse",
                "le ciel",
                "la lune",
                "le soleil",
                "un arbre",
                "une montagne",
                "un panda",
                "une masterball",
                "une peau de banane",
                "un bonnet",
                "le vide",
                "des ciseaux",
                "nous",
                "youtube",
                "des cartes",
                "un piano"
            };
            
            int nombre_de_phrases = 0;                  // Déclare la variable
            string entrée;                              // 
            bool play_again = true;                     //

            while (play_again == true)                       // Tant que playagain est true
            {
                Console.Clear();                             // Clear la console au début de chaque boucle
                
                do                       // Fait passer un message et demande une entrée de l'utilisateur. Boucle tant qu'il ne s'agit pas de l'entrée désirée.
                {
                    Console.WriteLine("Choisissez le nombre de phrases à générer");
                } while (!int.TryParse(Console.ReadLine(), out nombre_de_phrases));
                
                Console.WriteLine("");          // saute une ligne

                while (nombre_de_phrases != 0)           // Tant que le nombre de phrases choisies n'a pas atteint 0
                {
                    var rand = new Random();
                    int index = rand.Next(sujets.Count);         // Déclare un int "index" qui prend une valeur random parmis la liste donnée
                    Console.Write(sujets[index]);                // Marque dans la console l'entrée de la liste donnée correspondante à la valeur d'index

                    index = rand.Next(verbes.Count);             //
                    Console.Write(verbes[index]);                //

                    index = rand.Next(compléments.Count);        //
                    Console.Write(compléments[index]);           //

                    Console.WriteLine("");                       // Saute une ligne pour la prochaine phrase
                    nombre_de_phrases--;                         // Réduit de 1 le nombre de phrases à marquer
                }
                
                do                       // Fait passer un message et demande si l'utilisateur veut redémarrez le générateur. Boucle tant qu'il ne s'agit pas de l'entrée désirée.
                {
                    Console.WriteLine("\nVoulez-vous recommencez ?");
                    entrée = Console.ReadLine();
                } while (entrée != "Non" && entrée != "non" && entrée != "Oui" && entrée != "oui");

                if (entrée == "Non" || entrée == "non")         // Si l'utilisateur choisit non la boucle s'arrête, s'il choisit oui la première boucle while reprend.
                {
                    play_again = false;                    
                }
            }
        }
       
    }

}
