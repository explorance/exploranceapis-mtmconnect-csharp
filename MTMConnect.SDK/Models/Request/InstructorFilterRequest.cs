using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Instructors")]
    public class InstructorFilterRequest : BaseFilterRequest
    {
        public int? InstructorID { get; set; }
        public string InstructorEmail { get; set; }
        public string InstructorLastName { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += InstructorID != null ? $"&InstructorID ={InstructorID}" : string.Empty;
            query += !string.IsNullOrEmpty(InstructorEmail) ? $"&InstructorEmail ={InstructorEmail}" : string.Empty;
            query += !string.IsNullOrEmpty(InstructorLastName)  ? $"&InstructorLastName ={InstructorLastName}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
