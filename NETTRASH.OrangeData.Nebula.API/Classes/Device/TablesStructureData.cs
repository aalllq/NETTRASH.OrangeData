using System.Linq;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class TablesStructureData : Interfaces.IDeviceTablesStructureData
    {
        #region Private properties



        private TableStructureInfo[] _tables { get; set; }



        #endregion
        #region Public properties



        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        /// <value>Строка</value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Описания таблиц
        /// </summary>
        /// <value>Массив структур</value>
        [JsonProperty(PropertyName = "tables")]
        [JsonConverter(typeof(TableStructureInfo))]
        public Interfaces.IDeviceTableStructureInfo[] Tables
        {
            get
            {
                return _tables;
            }

            set
            {
                _tables = value.Select(v => new TableStructureInfo(v)).ToArray();
            }
        }



        #endregion
        #region Public constructors



        public TablesStructureData()
        {
        }



        #endregion
    }
}
