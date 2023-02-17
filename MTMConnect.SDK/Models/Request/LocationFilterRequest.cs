using System;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Locations")]
    public class LocationFilterRequest : BaseFilterRequest
    {
        public int? VendorLocationID { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += VendorLocationID != null ? $"&VendorLocationID ={VendorLocationID}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
