namespace MTMConnect.SDK.Models.Authentication
{
    public class TokenResponse:IResponse
    {
        public string access_token { get; set; }
        public string expires_in { get; set; }
        public string token_type { get; set; }
    }
}
