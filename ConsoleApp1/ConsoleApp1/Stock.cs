using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     class Stock
    {
        // les champs
        private List<Article> listArticles; 

        public Stock()
        {
            listArticles = new List<Article>(); // declaration d'une list 

        }
        public void AjouterArticle(int unNum, string unNom, decimal prixA, decimal prixV) // methode pour instancier un article 
        {                                                                                 // et la stocker dans la list
            listArticles.Add(new Article(unNum, unNom, prixA, prixV));
        }
        public void AfficherTousArticle()                     // methode pour parcourir la list et afficher les objets et leurs details
        {
            foreach(Article article in listArticles)
            {
                Console.WriteLine(article.GetInfo());

            }
        }

        public List<Article> GetListArticles()
        {
            return listArticles;
        }
        public void ChercheArticle()
        {
            
        }

        public void DeleteArticle()
        {
            //Collection.Remove()
        }

        
        public void FilterArticle(decimal prix)
        {
            // Collection.FindAll(Article.GetPrixAchat() > prix;
            //Article.GetPrixAchat() > prix;

        }
    }
}
