namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Responses")]
    public partial class Answer : BaseEntity
    {
        public int? EvalSubmittedID { get; set; }
        public int? EnrollmentID { get; set; }
        public string AnswerType { get; set; }
        public int? AnswerID { get; set; }
        public string AnswerData { get; set; }
        public int? QuestionID { get; set; }
        public int? ClassID { get; set; }
        public int? FormID { get; set; }
        public int? ScaleHigh { get; set; }
        public int? ScaleLow { get; set; }
    }
}
