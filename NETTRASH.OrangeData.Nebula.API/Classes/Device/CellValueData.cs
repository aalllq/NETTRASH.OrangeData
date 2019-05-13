using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class CellValueData : CellPositionData, Interfaces.IDeviceCellValueData
    {
        #region Public properties



        /// <summary>
        /// Данные ячейки таблицы устройства
        /// </summary>
        /// <value>Строка</value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }



        #endregion
        #region Public constructors



        public CellValueData()
            : base()
        {
        }


        public CellValueData(int nTable, int nRow, int nCell, string sValue)
            : base(nTable, nRow, nCell)
        {
            Value = sValue;
        }



        #endregion
    }
}
