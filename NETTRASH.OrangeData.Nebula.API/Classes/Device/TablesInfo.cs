using System;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class TablesInfo : JsonConverter, Interfaces.IDeviceTablesInfo
    {
        #region Public properties



        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        /// <value>Строка</value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Набор таблиц устройства
        /// </summary>
        /// <value>Массив структур</value>
        [JsonProperty(PropertyName = "tables")]
        [JsonConverter(typeof(TableData))]
        public Interfaces.IDeviceTableData[] Tables { get; set; }

        [JsonIgnore]
        public override bool CanWrite => true;

        [JsonIgnore]
        public override bool CanRead => true;



        #endregion
        #region Public constructors



        public TablesInfo()
        {
        }



        #endregion
        #region Public methods



        public override bool CanConvert(Type objectType)
        {
            return true; //TODO: need to fix
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<TablesInfo>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }



        #endregion
    }
}
