using System;
using System.Collections.Generic;
using System.Text;

namespace TP_1.services
{
    interface ITwitterService
    {
        bool Authenticate(string identifiant, string password);

        List<Tweet> GetTweets();
    }
}
