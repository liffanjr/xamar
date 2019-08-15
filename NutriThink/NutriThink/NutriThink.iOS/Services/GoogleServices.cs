//using System;
//using Foundation;
//using Google.SignIn;
//using NutriThink.iOS.Services;
//using NutriThink.Services;
//using UIKit;
//using Xamarin.Forms;

//[assembly: Dependency(typeof(GoogleServices))]
//namespace NutriThink.iOS.Services
//{
    //public class GoogleServices : NSObject, IGoogleServiceIOS, ISignInDelegate, ISignInUIDelegate
    //{
        //private Action<NutriThink.Models.GoogleUser, string> _onLoginComplete;
        //private UIViewController _viewController { get; set; }
        //
        //public GoogleServices()
        //{
        //    SignIn.SharedInstance.UIDelegate = this;
        //    SignIn.SharedInstance.Delegate = this;
        //}
        //
        ////public void Login(Action<NutriThink.Models.GoogleUser, string> OnLoginComplete)
        //public void Login()
        //{
        //    //_onLoginComplete = OnLoginComplete;
        //
        //    var window = UIApplication.SharedApplication.KeyWindow;
        //    var vc = window.RootViewController;
        //    while (vc.PresentedViewController != null)
        //    {
        //        vc = vc.PresentedViewController;
        //    }
        //
        //    _viewController = vc;
        //
        //    SignIn.SharedInstance.SignInUser();
        //}
        //
        //public void DidSignIn(SignIn signIn, Google.SignIn.GoogleUser user, NSError error)
        //{
        //    if (user != null && error == null)
        //        _onLoginComplete?.Invoke(new NutriThink.Models.GoogleUser()
        //        {
        //            Name = user.Profile.Name,
        //            Email = user.Profile.Email,
        //            Picture = new Uri(user.Profile.GetImageUrl(500).ToString())
        //        }, string.Empty);
        //    else
        //    {
        //        _onLoginComplete?.Invoke(null, error.LocalizedDescription);
        //    }
        //}
        //
        //public void Logout()
        //{
        //    SignIn.SharedInstance.SignOutUser();
        //
        //}
    //}
//}
