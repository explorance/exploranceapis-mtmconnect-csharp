using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Request
{
    [ServiceName("Vendors")]
    public class VendorFilterRequest : BaseFilterRequest
    {
        public int? OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public string ExternalVendorID { get; set; }

        internal override string GetQueryString()
        {
            string query = $"?PageSize={base.PageSize}&PageNumber={base.PageNumber}";
            query += OrganizationID != null ? $"&OrganizationID ={OrganizationID}" : string.Empty;
            query += !string.IsNullOrEmpty(OrganizationName) ? $"&OrganzationName ={OrganizationName}" : string.Empty;
            query += !string.IsNullOrEmpty(ExternalVendorID) ? $"&ExternalVendorID ={ExternalVendorID}" : string.Empty;
            query += base.Count ? $"&Count={base.Count}" : string.Empty;
            query += base.LastModifiedDate != null ? $"&LastModifiedDate={base.LastModifiedDate}" : string.Empty;
            return query;
        }
    }
}
