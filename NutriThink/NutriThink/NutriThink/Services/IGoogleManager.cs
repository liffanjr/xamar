using System;
using NutriThink.Models;

namespace NutriThink.Services
{
    public interface IGoogleManager
    {
        void Login(Action<GoogleUser, string> OnLoginComplete);
        void Logout();
    }
}
