using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class CellPositionData : Interfaces.IDeviceCellPositionData
    {
        #region Public properties



        /// <summary>
        /// Номер таблицы
        /// </summary>
        /// <value>Число</value>
        [JsonProperty(PropertyName = "table")]
        public int Table { get; set; }

        /// <summary>
        /// Номер ряда
        /// </summary>
        /// <value>Число</value>
        [JsonProperty(PropertyName = "row")]
        public int Row { get; set; }

        /// <summary>
        /// Номер поля
        /// </summary>
        /// <value>Число</value>
        [JsonProperty(PropertyName = "cell")]
        public int Cell { get; set; }



        #endregion
        #region Public constructors



        public CellPositionData()
        {
        }

        public CellPositionData(int nTable, int nRow, int nCell)
        {
            Table = nTable;
            Row = nRow;
            Cell = nCell;
        }



        #endregion
    }
}
