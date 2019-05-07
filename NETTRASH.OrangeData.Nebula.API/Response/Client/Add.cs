using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Response.Client
{
    public class Add : Base, Interfaces.IClientInfo
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



        public Add()
            : base()
        {
        }



        #endregion
        #region Public methods



        public static Add Load(string sSourceJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Add>(sSourceJson);
            }
            catch
            {
                return null;
            }
        }



        #endregion
    }
}
