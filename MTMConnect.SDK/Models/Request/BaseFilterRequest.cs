using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    public abstract class BaseFilterRequest :IRequest
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool Count { get; set; } = false;
        public DateTime? LastModifiedDate { get; set; }
        internal abstract string GetQueryString();      
    }
}
