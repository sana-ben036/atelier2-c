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

        // Method
        public void AjouterArticle(int a, string b, decimal c, decimal d) // methode pour instancier un article et la stocker dans la list
        {                                                                                 
            bool exist = listArticles.Exists(x => x.GetNumRef() == a);    // si le numRef deja exsist dans la list provoquer Exception
            if (exist == true) 
            { 
                throw new Exception(); 
            }
            else 
            {
                listArticles.Add(new Article(a, b, c, d));
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

            foreach (Article article in listArticles)    
            {
                if (article.GetNumRef() == a)
                {
                    Console.WriteLine(article.GetInfoArticle());
                }

            }

        }

       
        public void FilterArticle(decimal prix)     // afficher un article dont le prix d'achat est superieur d'un nombre donné
        {
            foreach (Article article in listArticles)
            {
                if (article.GetPrixAchat() > prix)
                {
                    Console.WriteLine(article.GetInfoArticle());
                }

            }

        }

        public void DeleteArticle( string nom)      // delete un article d'un nom determiné
        {
            foreach (Article article in listArticles)
            {
                if (article.GetNom() == nom)
                {
                    listArticles.Remove(article);
                    Console.WriteLine("un article est supprimé");
                }

            }
        }


        public void ModifierArticle(int r, string n, decimal a, decimal v) // update les info d'un article par le passage de son reference 
        {
            foreach (Article article in listArticles)
            {
                if (article.GetNumRef() == r)
                {
                    article.SetNom(n) ;
                    article.SetPrixAchat(a);
                    article.SetPrixVente(v);
                }
                

            }
        }


    }
}
