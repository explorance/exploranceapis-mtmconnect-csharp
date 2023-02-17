using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Responses")]
    public class AnswerFilterRequest : BaseFilterRequest
    {
        public int? EvalSubmittedID { get; set; }
        public int? ClassID { get; set; }
        public int? FormID { get; set; }
        public int? QuestionID { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += EvalSubmittedID != null ? $"&EvalSubmittedID ={EvalSubmittedID}" : string.Empty;
            query += ClassID != null ? $"&ClassID ={ClassID}" : string.Empty;
            query += FormID != null ? $"&FormID ={FormID}" : string.Empty;
            query += QuestionID != null ? $"&QuestionID ={QuestionID}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
