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
                /*
                 Stock unStock = new Stock();                  // instancier objet de la class stock

                  unStock.AjouterArticle(001, "aaa", 100, 300); // instancier et ajouter au list le premier nouveau article
                  unStock.AjouterArticle(002, "bbb", 100, 200);
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
                 */


                void Demarer()
                {
                    Console.WriteLine("Detrminer votre operation : Add, Search, Delete, Update, ChekList, FiltList");
                    string opt = Console.ReadLine();
                    Choix(opt);
                    void Choix(string opt)
                    {
                        Stock unStock = new Stock();
                        if (opt == "Add")
                        {
                            Console.WriteLine("Enter les info d'article : Numero , Nom, Prix d'achat , prix de vente");
                            int a = int.Parse(Console.ReadLine());
                            string b = Console.ReadLine();
                            int c = int.Parse(Console.ReadLine());
                            int d = int.Parse(Console.ReadLine());
                            unStock.AjouterArticle(a, b, c, d);
                            Console.WriteLine("---------------<<  list of articles  >>------------");
                            unStock.AfficherTousArticle();

                        }
                        else if (opt == "Search")
                        {
                            Console.WriteLine("Enter le numero  d'article :");
                            int a = int.Parse(Console.ReadLine());
                            unStock.ChercheArticle(a);

                        }
                        else if (opt == "Delete")
                        {
                            Console.WriteLine("Enter le nom de l'article :");
                            string nom = Console.ReadLine();
                            unStock.DeleteArticle(nom);

                        }
                        else if (opt == "Update")
                        {
                            Console.WriteLine("Enter le numero  d'article :");
                            int r = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter les nouveaux info : Nom, Prix d'achat , prix de vente");
                            string n = Console.ReadLine();
                            int a = int.Parse(Console.ReadLine());
                            int v = int.Parse(Console.ReadLine());

                            unStock.ModifierArticle(r, n, a, v);
                        }
                        else if (opt == "ChekList")
                        {
                            unStock.AfficherTousArticle();
                        }
                        else if (opt == "FiltrList")
                        {
                            Console.WriteLine("Afficher les article qu'ils ont un prix d'achat superieur que le prix saisie:");
                            decimal prix = decimal.Parse(Console.ReadLine());
                            unStock.FilterArticle(prix);
                        }

                    }
                } Demarer();
                









            }
            catch (Exception ex)
            {

                Console.WriteLine("error : {0}.", ex.Message);
            }
            finally
            {
                Console.WriteLine("----------Fin program---------"  );
            }

























        }
    }
}
