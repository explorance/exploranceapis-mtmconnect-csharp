using System;

namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Classes")]
    public partial class Class : BaseEntity
    {
        public int ClassID { get; set; }
        public int? EventID { get; set; }
        public string EventType { get; set; }        
        public int? SchedulingOrgID { get; set; }
        public int? VendorOrgID { get; set; }
        public string ClassName { get; set; }
        public int? ParentEventID { get; set; }
        public string ExternalClassID { get; set; }
        public DateTime? ClassStartDate { get; set; }
        public DateTime? ClassEndDate { get; set; }
        public bool? IsDeleted { get; set; }        
        public int? CourseID { get; set; }
        public int? LocationID { get; set; }
        public string LearningMethod { get; set; }
        public string InstructorID { get; set; }
    }
}
