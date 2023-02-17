namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Forms")]
    public partial class Form : BaseEntity
    {
        public int? FormID { get; set; }
        public string FormName { get; set; }
        public int? FormTypeID { get; set; }
        public string FormType { get; set; }
        public bool IsActive { get; set; }
        public bool? IsArchived { get; set; }
    }
}
