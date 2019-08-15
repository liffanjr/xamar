using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NutriThink.Models;
using NutriThink.Services;
using Xamarin.Auth;
using NutriThink.Authentication;
using System.Linq;
using System.Diagnostics;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace NutriThink.Views
{
    [DesignTimeVisible(false)]
    public partial class LandingPage : ContentPage
    {
        Account account;
        //SecureStorage storage;
            //public static Security.SecAccessible DefaultAccessible { get; set; }
        //SecureStorage SecureStorage;

        public LandingPage()
        {
            InitializeComponent();

            this.FindByName<StackLayout>("login").IsVisible = false;
            this.FindByName<StackLayout>("providerLogin").IsVisible = false;
            this.FindByName<StackLayout>("providerSingup").IsVisible = false;
            this.FindByName<AbsoluteLayout>("registerForm").IsVisible = false;
            this.FindByName<AbsoluteLayout>("loginForm").IsVisible = false;
        }

        public void OnStart(object sender, EventArgs args)
        {
            this.FindByName<StackLayout>("start").IsVisible = false;
            this.FindByName<StackLayout>("login").IsVisible = true;
        }

        public void OnLogin(object sender, EventArgs args)
        {
            this.FindByName<StackLayout>("providerLogin").IsVisible = true;
            this.FindByName<StackLayout>("providerSingup").IsVisible = false;
        }

        public void OnSignup(object sender, EventArgs args)
        {
            this.FindByName<StackLayout>("providerSingup").IsVisible = true;
            this.FindByName<StackLayout>("providerLogin").IsVisible = false;
        }

        public void GoogleLogin(object sender, EventArgs args)
        {
            string clientId = null;
            string redirectUri = null;

            if (Device.RuntimePlatform == Device.iOS)
            {
                clientId = Constants.iOSClientId;
                redirectUri = Constants.iOSRedirectUrl;
            }

            if (Device.RuntimePlatform == Device.Android)
            {
                clientId = Constants.AndroidClientId;
                redirectUri = Constants.AndroidRedirectUrl;

            }

            //account = SecureStorage.FindAccountsForService(Constants.AppName).FirstOrDefault();

            var authenticator = new OAuth2Authenticator(
                                    clientId,
                                    null,
                                    Constants.Scope,
                                    new Uri(Constants.AuthorizeUrl),
                                    new Uri(redirectUri),
                                    new Uri(Constants.AccessTokenUrl),
                                    null,
                                    true);

            authenticator.Completed += OnAuthCompleted;
            authenticator.Error += OnAuthError;

            AuthenticationState.Authenticator = authenticator;

            var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(authenticator);
        }

        async void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }

            GoogleUser user = null;
            if (e.IsAuthenticated)
            {
                // If the user is authenticated, request their basic user data from Google
                // UserInfoUrl = https://www.googleapis.com/oauth2/v2/userinfo
                var request = new OAuth2Request("GET", new Uri(Constants.UserInfoUrl), null, e.Account);
                var response = await request.GetResponseAsync();
                if (response != null)
                {
                    // Deserialize the data and store it in the account store
                    // The users email address will be used to identify data in SimpleDB
                    string userJson = await response.GetResponseTextAsync();
                    user = JsonConvert.DeserializeObject<GoogleUser>(userJson);
                }

                //if (account != null)
                //{
                //    store.Delete(account, Constants.AppName);
                //}

                //await SecureStorage.SetAsync(re);
                //await store.SaveAsync(account = e.Account, Constants.AppName);

                await DisplayAlert("Email address", user.Email, "OK");
            }
        }

        void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }

            Debug.WriteLine("Authentication error: " + e.Message);
        }
    }
}