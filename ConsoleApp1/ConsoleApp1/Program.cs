using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
               
                Stock unStock = new Stock();                  // instancier objet de la class stock
                
                unStock.AjouterArticle(001, "aaa", 100, 200); // instancier et ajouter au list le premier nouveau article
                //unStock.AjouterArticle(002, "bbb", 100, 200);
               // unStock.AjouterArticle(003, "ccc", 100, 300);
                //unStock.AjouterArticle(004, "ddd", 400, 600);
                unStock.AfficherTousArticle();                  // afficher tous les articles de la list avec leurs details
                //unStock.AjouterArticle(006, "kkk", 500, 400);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");
                unStock.ChercheArticle(1);                       // chercher l'article dont le reference est 1
                Console.WriteLine("----------------------------------");
                //unStock.FilterArticle(100);                      // chercher les article dont le prix d'achat > 100
                Console.WriteLine("----------------------------------");
                //unStock.DeleteArticle("fff");
                //Console.WriteLine("----------------------------------");

                Console.WriteLine("----------------------------------");
                unStock.ModifierArticle(1, "nouveau", 10, 20);       // modifier l'article dont le reference est un par nouveau nom, prixA, prix V
                unStock.AfficherTousArticle(); 










            }
            catch (Exception )
            {
                
                Console.WriteLine("ERROR"); // le message qui indique un erreur si la condition est true
            }
            
            finally
            {
                Console.WriteLine("--------------Terminer-----------------");
            }


            




















        }
    }
}
