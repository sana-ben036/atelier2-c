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
        public void ChercheArticle(int a)
        {
            bool exist = listArticles.Exists(x => x.GetNumRef() == a);    // si le numRef deja exsist dans la list provoquer Exception
            if (exist == true)
            {
                //Console.WriteLine("l'article recherché est exist : \n"+ listArticles.GetInfo()); 
            }
            else
            {
                
            }
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
