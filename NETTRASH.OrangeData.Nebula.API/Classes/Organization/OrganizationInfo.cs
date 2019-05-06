using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Organization
{
    [JsonObject]
    public class OrganizationInfo : OrganizationData, Interfaces.IOrganizationInfo
    {
        #region Public properties



        /// <summary>
        /// Дата добавления организации в БД Про-ставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "dateAdded")]
        public string CreateDate { get; set; }

        /// <summary>
        /// Количество неотправленных чеков в очереди
        /// </summary>
        /// <value>число, необяза-тельное поле</value>
        [JsonProperty(PropertyName = "queueCount")]
        public int? QueueCount { get; set; }

        /// <summary>
        /// Наличие в организации устройств с ошибками
        /// </summary>
        /// <value>логическоеl, необязательное поле</value>
        [JsonProperty(PropertyName = "hasDevicesWithErrors")]
        public bool? HasDevicesWithErrors { get; set; }



        #endregion
        #region Public constructors



        public OrganizationInfo()
            : base()
        {
        }



        #endregion
    }
}
