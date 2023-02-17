namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("BusinessUnits")]
    public class BusinessUnit : BaseEntity
    {
        public int? BusinessUnitID { get; set; }
        public string BusinessUnitName { get; set; }
        public bool IsActive { get; set; }
    }
}
