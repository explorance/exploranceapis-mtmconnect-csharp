namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("Questions")]
    public partial class Question : BaseEntity
    {
        public int? QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string  QuestionType { get; set; }
        public int? ParentQuestionID { get; set; }
    }
}
