using System;
using System.Collections.Generic;
using System.Text;

namespace TP_1.services
{
    class TwitterService : ITwitterService
    {
        public bool Authenticate(string identifiant, string password)
        {
             if(identifiant.Equals("Canards") && password.Equals("CoinCoin"))
            {
                return true;
            } else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public List<Tweet> GetTweets()
        {
            var tweets = new List<Tweet>();

            tweets.Add(new Tweet() { Identifiant = "1", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Ludo", IdentifiantUtilisateur = "1", PseudoUtilisateur = "Lulu" });
            tweets.Add(new Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Caro", IdentifiantUtilisateur = "2", PseudoUtilisateur = "Caro" });
            tweets.Add(new Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Nicolas", IdentifiantUtilisateur = "3", PseudoUtilisateur = "Nico" });
            tweets.Add(new Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Marine", IdentifiantUtilisateur = "4", PseudoUtilisateur = "Mimie" });
            tweets.Add(new Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Jérémy", IdentifiantUtilisateur = "5", PseudoUtilisateur = "Jérem" });
            tweets.Add(new Tweet() { Identifiant = "2", DateCreation = DateTime.Now, Texte = "Bonjour tout le monde !", NomUtilisateur = "Baptiste", IdentifiantUtilisateur = "6", PseudoUtilisateur = "Baptistou" });

            return tweets;
        }
    }
}
