namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Locations")]
    public partial class Location : BaseEntity
    {
        public int? VendorLocationID { get; set; }
        public string VendorLocationName { get; set; }
        public string ExternalLocationID { get; set; }
        public int? CertificationID { get; set; }
        public string CertificationName { get; set; }
        public string CertificationNumber { get; set; }
    }
}
