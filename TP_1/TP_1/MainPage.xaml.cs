﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_1.services;
using TP_1.views;
using Xamarin.Forms;

namespace TP_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //-------------------------------------------------------------------------------------------------------
        //Ajout d'un service
        private ITwitterService twitterService = new TwitterService();
        //-------------------------------------------------------------------------------------------------------
        public MainPage()
        {
            InitializeComponent();
            this.seConnecterBtn.Clicked += SeConnecterBtn_Clicked;
            //LoadTweets();
        }

        //private void LoadTweets()
        //{
        //    foreach (var item in twitterService.GetTweets())
        //    {
        //        AfficherTweets.Children.Add(new TP_1.Tweet().LoadData(item));
        //    }
        //}

        private void SeConnecterBtn_Clicked(object sender, EventArgs e)
        {
            Boolean result = true;
            String login = this.identifiant.Text;
            String password = this.motDePasse.Text;
            Boolean isRemind = this.memoriserInfos.IsToggled;
            bool haveError = false;
            bool testAuth = false;
            bool testInternet = false;
            StringBuilder stringBuilder = new StringBuilder();

            Debug.WriteLine("Coucou");


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
            
            if (Xamarin.Essentials.Connectivity.NetworkAccess == Xamarin.Essentials.NetworkAccess.Internet)
            {
                if (this.twitterService.Authenticate(login, password))
                {
                    testInternet = true;
                    //this.ConnexionForm.IsVisible = false;
                    //this.Tweets.IsVisible = true;
                    Navigation.PushAsync(new ListeTweets());
                }
                else
                {
                    stringBuilder.Append("Mot de passe et/ou identifiant invalide(s)");
                }
            }
            else
            {
                if (!haveError || !testAuth)
                {
                    stringBuilder.Append("\n");
                }
                stringBuilder.Append("Pas de connexion internet disponible !");
                testInternet = false;
            }

            if (haveError)
            {
                this.ErrorLabel.Text = stringBuilder.ToString();
            }

            result = !haveError;

            //if (result)
            //{
            //    this.ConnexionForm.IsVisible = false;
            //    this.Tweets.IsVisible = true;
            //}

            //throw new NotImplementedException();
        }

        public void Connection_Clicked()
        {

        }
    }
}
