using MTMConnect.SDK.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnectClient.SampleInput.Export
{
   public static class SampleRequest<Request> where Request:BaseFilterRequest,new()
    {
        public static Request GetSampleRequest()
        {
            return new Request()
            {
                PageNumber = 1,
                PageSize = 200,
                Count = true,
                LastModifiedDate = DateTime.Parse("2020-09-07T03:24:47.9474653")
            };
        }
    }
}
