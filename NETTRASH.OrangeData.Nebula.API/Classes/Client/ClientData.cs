using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Client
{
    [JsonObject]
    public class ClientData : Interfaces.IClientData
    {
        #region Public properties



        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор организации
        /// </summary>
        /// <value>Строка</value>
        [JsonProperty(PropertyName = "organizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Уникальное имя клиента
        /// </summary>
        /// <value>Строка до 64 символов</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// X.509 сертификат в формате Base-64
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «true» – агент заблокирован;
        ///   «false» - агент активен
        /// </summary>
        /// <value>Логический</value>
        [JsonProperty(PropertyName = "blocked")]
        public bool IsBlocked { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }



        #endregion
        #region Public constructors



        public ClientData()
        {
        }



        #endregion
    }
}
