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
            List<Tweet> tweets = null;
            Tweet tweet1 = new Tweet();
            tweet1.Identifiant = "1";
            tweet1.DateCreation = DateTime.Now;
            tweet1.Texte = "Bonjour tout le monde !";
            tweet1.NomUtilisateur = "Ludo";
            tweet1.IdentifiantUtilisateur = "1";
            tweet1.PseudoUtilisateur = "Lulu";

            tweets.Add(tweet1);

            Tweet tweet2 = new Tweet();
            tweet1.Identifiant = "2";
            tweet1.DateCreation = DateTime.Now;
            tweet1.Texte = "Bonjour tout le monde !";
            tweet1.NomUtilisateur = "Caro";
            tweet1.IdentifiantUtilisateur = "2";
            tweet1.PseudoUtilisateur = "Caro";

            tweets.Add(tweet2);

            Tweet tweet3 = new Tweet();
            tweet1.Identifiant = "3";
            tweet1.DateCreation = DateTime.Now;
            tweet1.Texte = "Bonjour tout le monde !";
            tweet1.NomUtilisateur = "Nicolas";
            tweet1.IdentifiantUtilisateur = "3";
            tweet1.PseudoUtilisateur = "Nico";

            tweets.Add(tweet3);

            return tweets
        }
    }
}
