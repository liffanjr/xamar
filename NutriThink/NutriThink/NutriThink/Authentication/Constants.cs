using System;
using Foundation;

namespace NutriThink.Authentication
{
    public static class Constants
    {
        //public static object googleClientDROID = NSDictionary.FromFile("google-services.json");
        //public static object googleClientIOS = NSDictionary.FromFile("GoogleService-Info.plist");

        public static string AppName = "NutriThink";

        // OAuth
        // For Google login, configure at https://console.developers.google.com/
        public static string iOSClientId = "151388010314-npm2s7mpq4aejvh2kmdesoum8b1grg73.apps.googleusercontent.com";
        public static string AndroidClientId = "151388010314-dgtc7nng0r3ng7adkmbn1jt6ln2iu2rv.apps.googleusercontent.com";

        // These values do not need changing
        public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
        public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
        public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
        public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

        // Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
        public static string iOSRedirectUrl = "com.googleusercontent.apps.151388010314-npm2s7mpq4aejvh2kmdesoum8b1grg73:/oauth2redirect";
        public static string AndroidRedirectUrl = "com.googleusercontent.apps.151388010314-dgtc7nng0r3ng7adkmbn1jt6ln2iu2rv:/oauth2redirect";
    }
}
