//using System;
//using Android.Content;
//using Android.Gms.Auth.Api;
//using Android.Gms.Auth.Api.SignIn;
//using Android.Gms.Common;
//using Android.Gms.Common.Apis;
//using Android.OS;
//using NutriThink.Droid.Services;
//using NutriThink.Services;
//using Xamarin.Forms;

//[assembly: Dependency(typeof(GoogleService))]
namespace NutriThink.Droid.Services
{
    //public class GoogleService : Java.Lang.Object, IGoogleServiceDROID, GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener
    //{
        //public Action<NutriThink.Models.GoogleUser, string> _onLoginComplete;
        //public static GoogleApiClient _googleApiClient { get; set; }
        //public static GoogleService googleManager { get; private set; }
        //
        //public GoogleService()
        //{
        //    googleManager = this;
        //    GoogleSignInOptions googleSignInOptions = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn)
        //                                                                        .RequestEmail()
        //                                                                        .Build();
        //
        //    _googleApiClient = new GoogleApiClient.Builder(((MainActivity)Forms.Context).ApplicationContext)
        //                                            .AddConnectionCallbacks(this)
        //                                            .AddOnConnectionFailedListener(this)
        //                                            .AddApi(Auth.GOOGLE_SIGN_IN_API, googleSignInOptions)
        //                                            .AddScope(new Scope(Scopes.Profile))
        //                                            .Build();
        //}
        //
        ////public void Login(Action<NutriThink.Models.GoogleUser, string> OnLoginComplete)
        //public void Login()
        //{
        //    //_onLoginComplete = OnLoginComplete;
        //    
        //    Intent signInIntent = Auth.GoogleSignInApi.GetSignInIntent(_googleApiClient);
        //    ((MainActivity)Forms.Context).StartActivityForResult(signInIntent, 1);
        //    _googleApiClient.Connect();
        //}
        //
        //public void Logout()
        //{
        //    _googleApiClient.Connect();
        //}
        //
        //public void OnAuthCompleted(GoogleSignInResult result)
        //{
        //    if (result.IsSuccess)
        //    {
        //        GoogleSignInAccount accountt = result.SignInAccount;
        //        _onLoginComplete?.Invoke(new NutriThink.Models.GoogleUser()
        //        {
        //            Name = accountt.DisplayName,
        //            Email = accountt.Email,
        //            Picture = new Uri((accountt.PhotoUrl.ToString()))
        //        }, string.Empty);
        //    }
        //    else
        //    {
        //        _onLoginComplete?.Invoke(null, "An error occured!");
        //    }
        //}
        //
        //
        //public void OnConnected(Bundle connectionHint)
        //{
        //    //throw new NotImplementedException();
        //}
        //
        //public void OnConnectionFailed(ConnectionResult result)
        //{
        //    //throw new NotImplementedException();
        //}
        //
        //public void OnConnectionSuspended(int cause)
        //{
        //    //throw new NotImplementedException();
        //}
    //}
}
