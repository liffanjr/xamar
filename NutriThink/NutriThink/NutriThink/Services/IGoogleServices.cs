using System;
using NutriThink.Models;

namespace NutriThink.Services
{
    public interface IGoogleServiceDROID
    {
        //void Login(Action<GoogleUser, string> OnLoginComplete);
        void Login();
        void Logout();
    }

    public interface IGoogleServiceIOS
    {
        void Login();
        void Logout();
    }
}
