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
                unStock.AjouterArticle(001, "aaa", 100, 200); // ajouter premier nouveau article
                unStock.AjouterArticle(002, "bbb", 100, 200);
                unStock.AjouterArticle(003, "ccc", 100, 300);
                unStock.AjouterArticle(004, "ddd", 400, 600);
                unStock.AjouterArticle(005, "fff", 500, 600);
                unStock.AfficherTousArticle();                  // afficher tous les articles de la list avec leurs details
                //Console.WriteLine(unStock.GetListArticles());
                //unStock.AjouterArticle(006, "kkk", 500, 400);









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
