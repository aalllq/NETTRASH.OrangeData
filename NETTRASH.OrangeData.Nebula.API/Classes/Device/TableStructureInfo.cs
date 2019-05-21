using System;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class TableStructureInfo : JsonConverter, Interfaces.IDeviceTableStructureInfo
    {
        #region Public properties



        /// <summary>
        /// Название таблицы
        /// </summary>
        /// <value>Строка</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Номер таблицы
        /// </summary>
        /// <value>Число</value>
        [JsonProperty(PropertyName = "number")]
        public int Number { get; set; }

        /// <summary>
        /// Количество колонок
        /// </summary>
        /// <value>Число</value>
        [JsonProperty(PropertyName = "columns")]
        public int Columns { get; set; }

        /// <summary>
        /// Количество строк
        /// </summary>
        /// <value>Число</value>
        [JsonProperty(PropertyName = "rows")]
        public int Rows { get; set; }

        [JsonIgnore]
        public override bool CanWrite => true;

        [JsonIgnore]
        public override bool CanRead => true;



        #endregion
        #region Public constructors



        public TableStructureInfo()
        {
        }

        public TableStructureInfo(Interfaces.IDeviceTableStructureInfo structure)
        {
            Name = structure.Name;
            Number = structure.Number;
            Columns = structure.Columns;
            Rows = structure.Rows;
        }



        #endregion
        #region Public methods



        public override bool CanConvert(Type objectType)
        {
            return true; //TODO: need to fix
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<TableStructureInfo>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }



        #endregion
    }
}
