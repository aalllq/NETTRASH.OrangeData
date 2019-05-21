using System;
using System.Linq;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class TableData : JsonConverter, Interfaces.IDeviceTableData
    {
        #region Private properties



        private CellInfoData[] _cells { get; set; }



        #endregion
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
        /// Ячейки
        /// </summary>
        /// <value>Набор структур</value>
        [JsonProperty(PropertyName = "cells")]
        [JsonConverter(typeof(CellInfoData))]
        public Interfaces.IDeviceCellInfoData[] Cells
        {
            get
            {
                return _cells;
            }

            set
            {
                _cells = value.Select(v => new CellInfoData(v)).ToArray();
            }
        }

        [JsonIgnore]
        public override bool CanWrite => true;

        [JsonIgnore]
        public override bool CanRead => true;



        #endregion
        #region Public properties



        public TableData()
        {
        }

        public TableData(Interfaces.IDeviceTableData table)
        {
            Name = table.Name;
            Number = table.Number;
            Cells = table.Cells.Select(c => new CellInfoData(c)).ToArray();
        }



        #endregion
        #region Public methods



        public override bool CanConvert(Type objectType)
        {
            return true; //TODO: need to fix
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<TableData>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }



        #endregion
    }
}
