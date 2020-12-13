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
               
                Stock unStock = new Stock();

                void Demarer()
                {
                    Console.WriteLine("Detrminer votre operation : Add, Search, Delete, Update, ChekList, FiltrList");
                    string opt = Console.ReadLine();
                    Choix(opt);
                    void Choix(string opt)
                    {
                        
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
                        Demarer();

                    }
                    
                }
                Demarer();











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
