using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("QuestionCategories")]
    public class QuestionCategoryFilterRequest : BaseFilterRequest
    {
        public int? QuestionCategoryID { get; set; }  // verify

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += QuestionCategoryID != null ? $"&QuestionID ={QuestionCategoryID}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
