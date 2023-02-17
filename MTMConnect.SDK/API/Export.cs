using MTMConnect.SDK.Models;
using MTMConnect.SDK.Models.Request;
using MTMConnect.SDK.Models.Response;
using MTMConnect.SDK.Models.Response.ErrorHandler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MTMConnect.SDK.API
{
   public class Export
    {
        public IOverallResponse GetEntities<Request,Response>(Request request, string baseUrl, string bearerToken) where Request:BaseFilterRequest where Response:BaseEntity
        {
            IOverallResponse response;
            try
            {
                var attr = typeof(Request).GetCustomAttributes(typeof(ServiceName), true).FirstOrDefault() as ServiceName;
                var queryString = $"{attr.Name}{request.GetQueryString()}";
                HttpUtility.HttpUtility httpUtility = new HttpUtility.HttpUtility();
                var responseContent = httpUtility.GetHttpResponse(baseUrl, bearerToken, queryString);
                if (responseContent.IsSuccessStatusCode)
                    response = JsonConvert.DeserializeObject<ResponseModel<Response>>(responseContent.Content.ReadAsStringAsync().Result);
                else
                    response = JsonConvert.DeserializeObject<ErrorResponse>(responseContent.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetEntityDetails", ex);
            }
            return response;
        }
    }
}
