using System;

namespace MTMConnect.SDK.Models.Response
{
    public class BaseEntity:IResponse
    {
        public DateTime? LastModifiedDate { get; set; }
    }
}
