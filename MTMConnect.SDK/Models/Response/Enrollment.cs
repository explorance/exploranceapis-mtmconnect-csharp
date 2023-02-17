using System;

namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Enrollments")]
    public partial class Enrollment : BaseEntity
    {
        public int? EnrollmentID { get; set; }
        public int? EventID { get; set; }
        public int? ClientID { get; set; }
        public string StudentIdentifier { get; set; }
        public int? BusinessUnitID { get; set; }
        public string ManagerIdentifier { get; set; }
        public DateTime? EnrollmentEnteredDate { get; set; }
    }
}
