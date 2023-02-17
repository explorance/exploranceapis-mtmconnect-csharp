using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Enrollments")]
    public class EnrollmentFilterRequest : BaseFilterRequest
    {
        public int? EnrollmentID { get; set; }
        public int? ClientID { get; set; }
        public int? BusinessUnitID { get; set; }
        public int? EventID { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += EnrollmentID != null ? $"&EnrollmentID ={EnrollmentID}" : string.Empty;
            query += ClientID != null ? $"&ClientID ={ClientID}" : string.Empty;
            query += BusinessUnitID != null ? $"&BusinessUnitID ={BusinessUnitID}" : string.Empty;
            query += EventID != null ? $"&EventID ={EventID}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
