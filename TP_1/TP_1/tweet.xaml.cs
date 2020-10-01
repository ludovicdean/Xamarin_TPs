using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tweet : ContentView
    {
        public Tweet()
        {
            InitializeComponent();
        }

        internal View LoadData(models.Tweet item)
        {
            TweetAuthor.Text = item.PseudoUtilisateur;
            TweetText.Text = item.Texte;
            return this;
        }
    }
}