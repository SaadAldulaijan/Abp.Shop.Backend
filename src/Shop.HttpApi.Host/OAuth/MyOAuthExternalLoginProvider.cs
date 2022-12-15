using Castle.Core.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Volo.Abp.Features;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.Identity.ExternalLoginProviders.OAuth;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Settings;

namespace Shop.OAuth
{
    public class MyOAuthExternalLoginProvider : OAuthExternalLoginProvider
    {
        public MyOAuthExternalLoginProvider(IGuidGenerator guidGenerator, 
            ICurrentTenant currentTenant, 
            IdentityUserManager userManager, 
            IIdentityUserRepository identityUserRepository, 
            IOptions<IdentityOptions> identityOptions, 
            OAuthExternalLoginManager oAuthExternalLoginManager, 
            ISettingProvider settingProvider, 
            IFeatureChecker featureChecker, 
            IOptions<AbpOAuthExternalLoginProviderOptions> options) 
            : base(guidGenerator, currentTenant, userManager, identityUserRepository, identityOptions, oAuthExternalLoginManager, settingProvider, featureChecker, options)
        {
        }


        protected override Task<ExternalLoginUserInfo> MapClaimsToExternalLoginUserInfoAsync(IEnumerable<Claim> claims)
        {

            var claimsArray = claims as Claim[] ?? claims.ToArray();
            return base.MapClaimsToExternalLoginUserInfoAsync(claims);
        }


    }
}
