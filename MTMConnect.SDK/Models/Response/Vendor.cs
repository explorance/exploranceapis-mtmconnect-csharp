namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Vendors")]
    public partial class Vendor : BaseEntity
    {
        public int? OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public bool IsActive { get; set; }
        public string ExternalVendorID { get; set; }
    }
}
