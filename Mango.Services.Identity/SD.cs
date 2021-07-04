using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.Identity
{
    public static class SD
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        // Defines Identity resources, named group of claims.
        public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource> { 
         new IdentityResources.OpenId(),
         new IdentityResources.Email(),
         new IdentityResources.Profile()
        };

        // Identity scopes: Identifiers to resources that client wants to access.
        // Two types of scopes: 1.Identity scope 2.Resource scope

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope> { 
                new ApiScope("mango", "Mango Server"),
                new ApiScope(name: "read", displayName: "Read the data."),
                new ApiScope(name: "write",displayName: "Write your data."),
                new ApiScope(name:"delete", displayName: "Delete your data.")
            };

        // Clients : A piece of software that requests an token from IDentityServer
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    ClientSecrets={ new Secret("Secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes={"read","write","profile"}
                },
                new Client
                {
                    ClientId = "mango",
                    ClientSecrets={ new Secret("Secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris={ "https://localhost:44305/signin-oidc" }, 
                    PostLogoutRedirectUris= { "https://localhost:44305/signout-callback-oidc" },
                    AllowedScopes=new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "mango"
                    }
                },
            };
    }
}
