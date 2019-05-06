using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.DeviceGroup
{
    public class DeviceGroupInfo : DeviceGroupData, Interfaces.IDeviceGroupInfo
    {
        #region Public properties



        /// <summary>
        /// Дата добавления группы устройств в БД Проставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "dateAdded")]
        public string CreateDate { get; set; }

        /// <summary>
        /// Количество неотправленных чеков в очереди
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "queueCount")]
        public int? QueueCount { get; set; }



        #endregion
        #region Public constructors



        public DeviceGroupInfo()
            : base()
        {
        }



        #endregion
    }
}
