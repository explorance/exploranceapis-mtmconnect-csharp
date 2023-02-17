using System;
using System.Collections.Generic;
using System.Text;
namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Courses")]
    public class CourseFilterRequest : BaseFilterRequest
    {
        public int? CourseID { get; set; }
        public bool? CourseActive { get; set; }
        public bool? Retired { get; set; }
        public string CourseName { get; set; }
        public string PorfolioName { get; set; }
        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += CourseID != null ? $"&CourseID ={CourseID}" : string.Empty;
            query += CourseActive != null ? $"&CourseActive ={CourseActive.ToString().ToLower()}" : string.Empty;
            query += Retired != null ? $"&Retired ={Retired.ToString().ToLower()}" : string.Empty;
            query += !string.IsNullOrEmpty(CourseName) ? $"&CourseName ={CourseName}" : string.Empty;
            query += !string.IsNullOrEmpty(PorfolioName) ? $"&PorfolioName ={PorfolioName}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}