using System;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class ErrorInfo : JsonConverter, Interfaces.IDeviceErrorInfo
    {
        #region Public properties



        /// <summary>
        /// Код ошибки, выданный устройством
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// Текстовое описание ошибки
        /// </summary>
        /// <value>Строка</value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonIgnore]
        public override bool CanRead => true;

        [JsonIgnore]
        public override bool CanWrite => true;



        #endregion
        #region Public constructors



        public ErrorInfo()
        {
        }

        public ErrorInfo(Interfaces.IDeviceErrorInfo error)
        {
            Code = error.Code;
            Message = error.Message;
        }



        #endregion
        #region Public methods



        public override bool CanConvert(Type objectType)
        {
            return true; //TODO: fix it
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<ErrorInfo>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }



        #endregion
    }
}
