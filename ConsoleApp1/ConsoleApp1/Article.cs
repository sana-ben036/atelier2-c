using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Article
    {
        // les champs
        private int numRef;
        private string nom;
        private decimal prixAchat;
        private decimal prixVente;

        // les methodes
        public  Article(int unNum, string unNom, decimal prixA, decimal prixV) // methode pour l'instanciation 
        {
            numRef = unNum;
            nom = unNom;
          
            if( prixVente < prixAchat)         // une condition provoquant l'exception lors de l'instanciation
            {
                throw new Exception  ();
            }
            else 
            {
                prixAchat = prixA;
                prixVente = prixV;
            }

        }

        public string GetInfoArticle()         // methode pour récuperer les infos de l'article(getter)
        {
            string info = "le reference d'article : " + numRef +"\n"
                + "le nom d'article : " + nom +"\n"
                + "le prix d'achat : " + prixAchat + " DH \n"
                + "le prix de vente : " + prixVente + " DH \n";

            return info;
            
        }

        public decimal GetPrixAchat()
        {
            return prixAchat;
        }

        public int GetNumRef()
        {
            return numRef;
        }

        public string GetNom()
        {
            return nom;
        }






    }
}
