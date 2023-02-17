using System;
using System.Collections.Generic;
using System.Text;
namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Forms")]
    public class FormFilterRequest : BaseFilterRequest
    {
        public int? FormID { get; set; }  // verify
        public int? FormTypeID { get; set; }
        public bool? IsArchived { get; set; }
        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += FormID != null ? $"&FormID ={FormID}" : string.Empty;
            query += FormTypeID != null ? $"&FormTypeID ={FormTypeID}" : string.Empty;
            query += IsArchived != null ? $"&IsArchived ={IsArchived.ToString().ToLower()}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}