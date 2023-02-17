using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Classes")]
    public class ClassFilterRequest : BaseFilterRequest
    {
        public int? ClassId { get; set; }
        public int? VendorID { get; set; }
        public int? CourseID { get; set; }
        public int? LearningMethodID { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += ClassId != null ? $"&ClassId ={ClassId}" : string.Empty;
            query += VendorID != null ? $"&VendorID ={VendorID}" : string.Empty;
            query += CourseID != null ? $"&CourseID ={CourseID}" : string.Empty;
            query += LearningMethodID != null ? $"&LearningMethodID ={LearningMethodID}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
