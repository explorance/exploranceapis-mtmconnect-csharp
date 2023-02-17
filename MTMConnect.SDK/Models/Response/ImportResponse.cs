using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace MTMConnect.SDK.Models.Response
{
    [ServiceName("ImportResponse")]
    public class ImportResponse :BaseEntity ,IOverallResponse
    {
        public Guid ImportId { get; set; }
        public string Message { get; set; }

        public QueueHistory History { get; set; }
    }
    public class QueueHistory
    {
        public bool Removed { get; set; }
        public List<Stages> Stages { get; set; }
        [JsonIgnore]
        public int CurrentStageId { get; set; }
        [JsonIgnore]
        public string ImportType { get; set; }
    }
    public class Stages
    {
        public string Status { get; set; }
        public DateTime Date { get; set; }
        [JsonIgnore]
        public int StageId { get; set; }
        [JsonIgnore]
        public bool Removed { get; set; }
        [JsonIgnore]
        public string DisplayStatus { get; set; }
        [JsonIgnore]
        public int ImportType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue("")]
        public string Error { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public JsonDetail Detail { get; set; }

    }
    public class JsonDetail
    {
        public Progressdetail[] progressDetails { get; set; }
    }

    public class Progressdetail
    {
        public string Item { get; set; }
        public Stats Stats { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Detail Detail { get; set; }
    }

    public class Stats
    {
        public int Total { get; set; }
        public int Added { get; set; }
        public int Updated { get; set; }
        public int NotProcessed { get; set; }
        public int Failed { get; set; }
    }

    public class Detail
    {
        public string Type { get; set; }
        public string Message { get; set; }
    }

}
