using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NutriThink.Models;

namespace NutriThink.Views
{
    [DesignTimeVisible(false)]
    public partial class LandingPage : ContentPage
    {
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
            if (Device.RuntimePlatform == Device.iOS)
            {
                //Login(null, null);
            }

            if (Device.RuntimePlatform == Device.Android)
            {

            }
        }
    }
}