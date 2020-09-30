using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.seConnecterBtn.Clicked += SeConnecterBtn_Clicked;
        }

        private void SeConnecterBtn_Clicked(object sender, EventArgs e)
        {
            System.Console.WriteLine("Coucou");

            Boolean result = true;
            String login = this.identifiant.Text;
            String password = this.motDePasse.Text;
            Boolean isRemind = this.memoriserInfos.IsToggled;

            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(login) || login.Length < 3)
            {
                haveError = true;
                stringBuilder.Append("L'identifiant ne peut pas être vide et doit posséder au moins 3 caractères.");
            }

            if (String.IsNullOrEmpty(password) || password.Length < 6)
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("Le mot de passe ne peut pas être vide et doit posséder au moins 6 caractères.");
            }

            if (haveError)
            {
                this.ErrorLabel.Text = stringBuilder.ToString();
            }

            result = !haveError;

            if (result)
            {
                this.ConnexionForm.IsVisible = false;
                this.Tweets.IsVisible = true;
            }
            //throw new NotImplementedException();
        }

        public void Connection_Clicked()
        {

        }
    }
}
