using MTMConnect.SDK.HttpUtility;
using MTMConnect.SDK.Models;
using MTMConnect.SDK.Models.Authentication;
using MTMConnect.SDK.Models.Request;
using MTMConnect.SDK.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace MTMConnect.SDK.Authentication
{
    public class AuthenticationService
    {
        /// <summary>
        /// Get the token from the given authentication api service and pass it to the front end.
        /// </summary>
        /// <returns></returns>
        public TokenResponse GetAuthenticationToken(TokenRequest authRequest,string tokenUrl)
        {
            TokenResponse tokenResponse;       
            try
            {
                HttpUtility.HttpUtility httpUtility = new HttpUtility.HttpUtility();
                var responseContent = httpUtility.PostHttpRequest<TokenResponse>(authRequest.ToString(),tokenUrl, null,"application/x-www-form-urlencoded");
                tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception("Authentication failed", ex);
            }
            return tokenResponse;
        }
    }
}
