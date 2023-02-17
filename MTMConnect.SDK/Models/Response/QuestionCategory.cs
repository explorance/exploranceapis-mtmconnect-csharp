namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("QuestionCategories")]
    public partial class QuestionCategory : BaseEntity
    {
        public int? QuestionCategoryID { get; set; }
        public string QuestionCategoryText { get; set; }
    }
}
