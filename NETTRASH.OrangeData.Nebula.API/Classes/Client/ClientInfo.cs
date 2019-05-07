using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Client
{
    [JsonObject]
    public class ClientInfo : ClientData, Interfaces.IClientInfo
    {
        #region Public properties



        /// <summary>
        /// Дата добавления организации в БД. Проставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "dateAdded")]
        public string CreateDate { get; set; }

        /// <summary>
        /// Отпечаток сертификата клиента
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Кому выдан сертификат клиента
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Издатель сертификата клиента
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Начало действия сертификата клиента
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "validFrom")]
        public string ValidFrom { get; set; }

        /// <summary>
        /// Окончание действия сертификата клиента
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "validTo")]
        public string ValidTo { get; set; }



        #endregion
        #region Public constructors



        public ClientInfo()
        {
        }



        #endregion
    }
}
