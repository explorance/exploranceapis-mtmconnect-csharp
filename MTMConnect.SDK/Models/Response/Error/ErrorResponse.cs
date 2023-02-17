using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models.Response.ErrorHandler
{
    public class ErrorResponse : IOverallResponse
    {
        [JsonProperty(Order = 10)]
        public int InternalCode { get; set; }

        private string message;

        [JsonProperty(Order = 20)]
        public string Message
        {
            get { return "Error - " + message; }
            set { message = value; }
        }

        [JsonProperty(Order = 30)]
        public int Code { get; set; }
    }
}
