using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace ZirveWinService.Library.Models
{
    public class ReturnData : IReturnData
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ReturnStatus Status { get; set; }
        public string Message { get; set; }
        ReturnStatus IReturnData.Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class ReturnData<T> : IReturnData<T>
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ReturnStatus Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public int TotalCount { get; set; }
        public DateTime ServerTime { get; set; } = DateTime.Now;
    }
}
