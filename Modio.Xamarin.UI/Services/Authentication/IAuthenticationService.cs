﻿using Modio.Xamarin.UI.Models;
using System.Threading.Tasks;

namespace Modio.Xamarin.UI.Services.Authentication
{
    public interface IAuthenticationService
    {
        bool IsAuthenticated { get; }

        User AuthenticatedUser { get; }

        Task<bool> LoginAsync(string email, string password);

        Task<bool> LoginWithMicrosoftAsync();

        Task<bool> UserIsAuthenticatedAndValidAsync();

        Task LogoutAsync();
    }
}
