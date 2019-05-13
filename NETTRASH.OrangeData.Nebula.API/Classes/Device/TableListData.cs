using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class TableListData : Interfaces.IDeviceTableListData
    {
        #region Public properties



        [JsonProperty(PropertyName = "tables")]
        public int[] Tables { get; set; }



        #endregion
        #region Public constructors



        public TableListData()
        {
        }

        public TableListData(int[] tables)
        {
            Tables = tables;
        }



        #endregion
    }
}
