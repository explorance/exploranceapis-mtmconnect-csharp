using MTMConnect.SDK.Models;
using MTMConnect.SDK.Models.Request;
using MTMConnect.SDK.Models.Response;
using MTMConnect.SDK.Models.Response.ErrorHandler;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace MTMConnect.SDK.API
{
    public class Import
    {
        public IOverallResponse GetImportStatus<Response>(Guid importId, string baseUrl,string bearerToken)  where Response : ImportResponse
        {
            IOverallResponse response;
            try
            {
                string getURLFormat = "Status?ImportId={0}";
                var queryString = string.Format(getURLFormat, importId);
                HttpUtility.HttpUtility httpUtility = new HttpUtility.HttpUtility();
                var responseContent = httpUtility.GetHttpResponse(baseUrl,bearerToken, queryString);
                if (responseContent.IsSuccessStatusCode)
                    response = JsonConvert.DeserializeObject<Response>(responseContent.Content.ReadAsStringAsync().Result);
                else
                    response = JsonConvert.DeserializeObject<ErrorResponse>(responseContent.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetImportStatus", ex);
            }
            return response;
        }
        public Response DeleteImportId<Response>(Guid importId, string baseUrl, string bearerToken) where Response : ImportResponse
        {
            Response response;
            try
            {
                string getURLFormat = "Remove?ImportId={0}";
                var queryString = string.Format(getURLFormat, importId);
                HttpUtility.HttpUtility httpUtility = new HttpUtility.HttpUtility();
                var responseContent = httpUtility.DeleteHttpRequest<Response>(baseUrl, bearerToken, queryString);
                response = JsonConvert.DeserializeObject<Response>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DeleteImportQueueId", ex);
            }
            return response;
        }
        public Response ImportJson< Response>(string requestJsonString, string baseUrl, string bearerToken)  where Response : ImportResponse
        {
            Response response;
            try
            {
                string getURLFormat = "{0}Import";
                string postUrl = string.Format(getURLFormat, baseUrl);
                HttpUtility.HttpUtility httpUtility = new HttpUtility.HttpUtility();
                string inputType = "application/json";
                var responseContent = httpUtility.PostHttpRequest<Response>(requestJsonString, postUrl, bearerToken, inputType);
                response = JsonConvert.DeserializeObject<Response>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ImportJson", ex);
            }
            return response;
        }
        public Response ImportXml< Response>(string requestXmlString, string baseUrl,string bearerToken) where Response : ImportResponse
        {
            Response response;
            try
            {
                string getURLFormat = "{0}Import";
                string postUrl = string.Format(getURLFormat, baseUrl);
                HttpUtility.HttpUtility httpUtility = new HttpUtility.HttpUtility();
                string inputType = "application/xml";
                var responseContent = httpUtility.PostHttpRequest< Response>(requestXmlString, postUrl, bearerToken, inputType);
                response = JsonConvert.DeserializeObject<Response>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ImportXml", ex);
            }
            return response;
        }

    }
}
