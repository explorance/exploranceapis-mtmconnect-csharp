namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Instructors")]
    public partial class Instructor : BaseEntity
    {
        public int? InstructorID { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public string ExternalInstructorID { get; set; }
        public string InstructorEmail { get; set; }
        public int? CertificationID { get; set; }
        public string CertificationName { get; set; }
        public string CertificationNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
