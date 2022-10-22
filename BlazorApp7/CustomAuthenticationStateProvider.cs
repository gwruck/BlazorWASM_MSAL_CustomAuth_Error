using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorApp7
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity());

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonymous = new ClaimsIdentity();
            await Task.FromResult(0);
            return new AuthenticationState(claimsPrincipal);

        }
    }
}
