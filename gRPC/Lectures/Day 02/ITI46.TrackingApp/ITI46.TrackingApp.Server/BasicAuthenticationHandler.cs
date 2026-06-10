using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace ITI46.TrackingApp.Server
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            // Header: Authorization: Basic base64(username:password)
            if (Request.Headers.ContainsKey("Authorization"))
            {
                // Basic username:password
                var header = Request.Headers["Authorization"].ToString();

                // encoded(username:password)
                string token = header.Split(' ')[1];

                // username:password
                var bytes = Convert.FromBase64String(token);
                string plainText = Encoding.UTF8.GetString(bytes);

                int index = plainText.IndexOf(':');
                string username = plainText.Substring(0, index);
                string password = plainText.Substring(index + 1);

                if (username == "admin" && password == "P@ssw0rd")
                {
                    // context.User.Identity.Name
                    var principal = new ClaimsPrincipal(
                        new ClaimsIdentity([
                            new Claim(ClaimTypes.Name, username),
                            new Claim(ClaimTypes.Role, "Administrator")
                            ])
                    );

                    return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(principal, Scheme.Name)));                
                }
            }

            return Task.FromResult(AuthenticateResult.Fail("Unsupported Authentication"));
        }
    }
}