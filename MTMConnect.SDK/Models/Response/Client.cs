namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Clients")]
    public partial class Client : BaseEntity
    {
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public bool IsActive { get; set; }        
    }
}
