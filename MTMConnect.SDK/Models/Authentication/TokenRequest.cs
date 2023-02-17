namespace MTMConnect.SDK.Models.Authentication
{
    public class TokenRequest:IRequest
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Scope { get; set; }
        public string GrantType { get; set; }
        public override string ToString()
        {
            return $"grant_type={GrantType}&scope={Scope}&client_id={ClientId}&client_secret={ClientSecret}";
        }
    }
}
