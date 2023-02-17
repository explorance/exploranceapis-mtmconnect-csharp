using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Clients")]
    public class ClientFilterRequest : BaseFilterRequest
    {
        public int? ClientId { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += ClientId != null ? $"&ClientId ={ClientId}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
