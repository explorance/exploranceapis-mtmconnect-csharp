using System;

namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Courses")]
    public partial class Course : BaseEntity
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public bool CourseActive { get; set; }
        public bool Retired { get; set; }
        public string PortfolioName { get; set; }
        public string ChannelName { get; set; }         
    }
}
