using System;
using System.Collections.Generic;
using System.Text;

namespace TP_1.services
{
    class TwitterService : ITwitterService
    {
        public bool Authenticate(string identifiant, string password)
        {
             
            
            if(string.IsNullOrEmpty(identifiant) || string.IsNullOrEmpty(password) || !identifiant.Equals("Canards") || !password.Equals("CoinCoin"))
            {
                return false;
            } else
            {
                return true;
            }
        }

        public List<models.Tweet> GetTweets()
        {
            var tweets = new List<models.Tweet>();

            tweets.Add(new models.Tweet() { Identifiant = "1", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Ludo", IdentifiantUtilisateur = "1", PseudoUtilisateur = "Lulu" });
            tweets.Add(new models.Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Caro", IdentifiantUtilisateur = "2", PseudoUtilisateur = "Caro" });
            tweets.Add(new models.Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Nicolas", IdentifiantUtilisateur = "3", PseudoUtilisateur = "Nico" });
            tweets.Add(new models.Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Marine", IdentifiantUtilisateur = "4", PseudoUtilisateur = "Mimie" });
            tweets.Add(new models.Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Jérémy", IdentifiantUtilisateur = "5", PseudoUtilisateur = "Jérem" });
            tweets.Add(new models.Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Baptiste", IdentifiantUtilisateur = "6", PseudoUtilisateur = "Baptistou" });

            return tweets;
        }
    }
}
