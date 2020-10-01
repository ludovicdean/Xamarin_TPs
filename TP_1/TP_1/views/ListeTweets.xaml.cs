using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_1.services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_1.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeTweets : ContentPage
    {
        TwitterService ts = new TwitterService();
        public ListeTweets()
        {
            
            InitializeComponent();
            List<models.Tweet> tweets = ts.GetTweets();
            ObservableCollection<models.Tweet> octweets = new ObservableCollection<models.Tweet>();

            foreach (var item in tweets)
            {
                octweets.Add(item);
            }
            
            this.TweetsListe.ItemsSource = octweets;

        }
    }
}