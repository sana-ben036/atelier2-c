using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Stock
    {
        // les champs
        private List<Article> listArticles;
        public Article art;
        public Stock()
        {
            listArticles = new List<Article>(); // declaration d'une list 

        }

        // Method
        
        public void AjouterArticle(Article art)                                                            // methode pour instancier un article et la stocker dans la list
        {
            bool exist = listArticles.Exists(x => x.GetNumRef() == art.GetNumRef());                         // si le numRef deja exsist dans la list provoquer Exception
            if (exist == true) 
            { 
                throw new Exception("L'article déja enregisté"); 
            }
           
            else 
            {
                listArticles.Add(art);
            }
            

        }
        public void AfficherTousArticle()                     // parcourir la list et afficher les objets et leurs details
        {
            foreach(Article article in listArticles)
            {
                Console.WriteLine(article.GetInfoArticle());

            }
        }

        
        public void ChercheArticle(int a)                      // chercher un article par un attribut et afficher ses details
        {

           
            if (listArticles.Count > 0)
            {
                Article article = listArticles.Find(article => article.GetNumRef() == a);
                if (article != null)
                {
                    Console.WriteLine(article.GetInfoArticle());
                }
                else
                {
                    Console.WriteLine("l'article recherché est introuvable");
                }
            }
            else
            {
                Console.WriteLine("La list est vide");
            }
        }

       
        public void FilterArticle(decimal prix)                       // afficher un article dont le prix d'achat est superieur d'un nombre donné
        {
            
            if (listArticles.Count > 0)
            {
                Article article = listArticles.Find(article => article.GetPrixAchat() > prix);
                if (article != null)
                {
                    Console.WriteLine(article.GetInfoArticle());
                }
                else
                {
                    Console.WriteLine("l'article recherché est introuvable");
                }
            }
            else
            {
                Console.WriteLine("La list est vide");
            }

        }

        public void DeleteArticle(string nom) // delete un article d'un nom determiné
        {
            if (listArticles.Count > 0)
            {
                listArticles.RemoveAll(article => article.GetNom() == nom);
            }
            else
            {
                Console.WriteLine("La list est vide");
            }
        }


        public void ModifierArticle(int r, string n, decimal a, decimal v)              // update les info d'un article par le passage de son reference 
        {
           
            if (listArticles.Count > 0)
            {
                Article article = listArticles.Find(article => article.GetNumRef() == r);
                if (article != null)
                {
                    article.SetNom(n);
                    article.SetPrixAchat(a);
                    article.SetPrixVente(v);
                }
                else
                {
                    Console.WriteLine("l'article recherché est introuvable");
                }
            }
            else
            {
                Console.WriteLine("La list est vide");
            }
        }


    }
}
