namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("DemographicResponses")]
    public partial class DemographicAnswer : BaseEntity
    {
        public int? EventID { get; set; }
        public int? EnrollmentID { get; set; }
        public int? DemographicQuestionID { get; set; }
        public string QuestionText { get; set; }
        public int? DemographicOptionID { get; set; }
        public string AnswerText { get; set; }
    }
}
