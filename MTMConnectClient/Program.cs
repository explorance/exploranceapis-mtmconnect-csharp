using MTMConnect.SDK.API;
using MTMConnect.SDK.Authentication;
using MTMConnect.SDK.Models.Authentication;
using MTMConnect.SDK.Models.Request;
using MTMConnect.SDK.Models.Response;
using MTMConnectClient.SampleInput.Export;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace MTMConnectClient
{
    class Program
    {
        private static string environmentpath = AppDomain.CurrentDomain.BaseDirectory;
        private static string localXmlFilePath = "\\SampleInput\\ImportFiles\\ImportXmlFomat.xml";
        private static string localJsonFilePath = "\\SampleInput\\ImportFiles\\ImportJsonFormat.json";
        #region ConfigDetails
        private static string authenticationClientSecret = ConfigurationSettings.AppSettings["client_secret"];
        private static string authenticationClientId = ConfigurationSettings.AppSettings["client_id"];
        private static string authenticationGrantType = ConfigurationSettings.AppSettings["grant_type"];
        private static string authenticationScope = ConfigurationSettings.AppSettings["scope"];
        private static string authenticationServiceUrl = ConfigurationSettings.AppSettings["authenticationServiceUrl"];
        private static string instanceUrl = ConfigurationSettings.AppSettings["dataServiceUrl"];
        private static string apiVersion = ConfigurationSettings.AppSettings["apiVersion"];
        private static string baseUrl = $"{instanceUrl}/v{apiVersion}/";
        #endregion
        
        static void Main(string[] args)
        {   
            AuthenticationService authenticationService = new AuthenticationService();
            var tokenResponse = authenticationService.GetAuthenticationToken(new TokenRequest()
            {
                ClientId = authenticationClientId,
                ClientSecret = authenticationClientSecret,
                GrantType = authenticationGrantType,
                Scope = authenticationScope,

            }, authenticationServiceUrl);

            #region Export
            Export export = new Export();
            CourseFilterRequest request = SampleRequest<CourseFilterRequest>.GetSampleRequest();
            request.CourseActive = true;
            var response = export.GetEntities<CourseFilterRequest, Course>(request, baseUrl, tokenResponse.access_token);
            Console.WriteLine("Export Response");
            Console.WriteLine(JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
            #endregion

            #region Import
            string xmlSampleInput = File.ReadAllText(environmentpath + localXmlFilePath);
            Import import = new Import();
            var importXmlResponse = import.ImportXml<ImportResponse>(xmlSampleInput, baseUrl, tokenResponse.access_token);
            Console.WriteLine("Import Xml Response");
            Console.WriteLine(JsonConvert.SerializeObject(importXmlResponse, Newtonsoft.Json.Formatting.Indented));
            Guid importId = importXmlResponse.ImportId;

            // Get the status of the above import request
            var statusResponse = import.GetImportStatus<ImportResponse>(new Guid(), baseUrl, tokenResponse.access_token);
            Console.WriteLine("Import Status Response");
            Console.WriteLine(JsonConvert.SerializeObject(statusResponse, Newtonsoft.Json.Formatting.Indented));

            // Delete the above import request
            var deleteImportResponse = import.DeleteImportId<ImportResponse>(importId, baseUrl, tokenResponse.access_token);
            Console.WriteLine("Delete Import Response");
            Console.WriteLine(JsonConvert.SerializeObject(deleteImportResponse, Newtonsoft.Json.Formatting.Indented));
            #endregion
        }
    }
}
