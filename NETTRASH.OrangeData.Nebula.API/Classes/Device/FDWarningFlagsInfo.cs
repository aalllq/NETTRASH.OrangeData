using System;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class FDWarningFlagsInfo : JsonConverter, Interfaces.IDeviceFDWarningFlagsInfo
    {
        #region Public properties



        /// <summary>
        /// Значение
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "value")]
        public int? Value { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonIgnore]
        public override bool CanRead => true;

        [JsonIgnore]
        public override bool CanWrite => true;



        #endregion
        #region Public constructors



        public FDWarningFlagsInfo()
        {
        }

        public FDWarningFlagsInfo(Interfaces.IDeviceFDWarningFlagsInfo warning)
        {
            Value = warning.Value;
            Description = warning.Description;
        }



        #endregion
        #region Public methods



        public override bool CanConvert(Type objectType)
        {
            return true; //TODO: fix it
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<FDWarningFlagsInfo>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }



        #endregion
    }
}
