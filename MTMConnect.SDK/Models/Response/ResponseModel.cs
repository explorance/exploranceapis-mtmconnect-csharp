using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Response
{
    public class ResponseModel<Response> : IOverallResponse
    {
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public int? TotalRecords { get; set; }
        public IEnumerable<Response> Data { get; set; }
    }
}
