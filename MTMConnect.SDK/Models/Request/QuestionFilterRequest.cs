using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Questions")]
    public class QuestionFilterRequest : BaseFilterRequest
    {
        public int? QuestionID { get; set; }  // verify
        public int? QuestionType { get; set; }
        public int? QuestionCategoryID { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += QuestionID != null ? $"&QuestionID ={QuestionID}" : string.Empty;
            query += QuestionType != null ? $"&QuestionType ={QuestionType}" : string.Empty;
            query += QuestionCategoryID != null ? $"&QuestionCategoryID ={QuestionCategoryID}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
