using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("DemographicResponses")]
    public class DemographicAnswerFilterRequest : BaseFilterRequest
    {
        public int? EventID { get; set; }
        public int? EnrollmentID { get; set; }
        public int? DemographicQuestionID { get; set; }
        public string QuestionText { get; set; }
        public int? DemographicOptionID { get; set; }
        public string AnswerText { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += EventID != null ? $"&EventID ={EventID}" : string.Empty;
            query += EnrollmentID != null ? $"&EnrollmentID ={EnrollmentID}" : string.Empty;
            query += DemographicQuestionID != null ? $"&DemographicQuestionID ={DemographicQuestionID}" : string.Empty;
            query += !string.IsNullOrEmpty(QuestionText) ? $"&QuestionText ={QuestionText}" : string.Empty;
            query += DemographicOptionID != null ? $"&DemographicOptionID ={DemographicOptionID}" : string.Empty;
            query += !string.IsNullOrEmpty(AnswerText) ? $"&AnswerText ={AnswerText}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
