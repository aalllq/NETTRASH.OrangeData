using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Response.DeviceGroup
{
    public class Add : Base, Interfaces.IDeviceGroupInfo
    {
        #region Public properties



        /// <summary>
        /// Идентификатор документа
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор организации
        /// </summary>
        /// <value>Строка до 32 символов</value>
        [JsonProperty(PropertyName = "organizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Уникальное в пределах организации имя группы устройств
        /// </summary>
        /// <value>Строка до 32 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Код налоговой системы. При наличии переопределяет систему налогообложения
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "taxSystem")]
        public TaxSystemEnumeration TaxSystem { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Тип ключа используемого для подписи:
        ///   0 – используется подпись SHA256-RSA;
        ///   1 – подпись не используется
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "keyType")]
        public SignatureTypeEnumeration SignatureType { get; set; }

        /// <summary>
        /// Временная зона, в которой находятся все устройства этой группы. Смещение относительно UTC, на текущий момент в РФ это от 2 до 12
        /// </summary>
        /// <value>Число</value>
        [JsonProperty(PropertyName = "timeZone")]
        public short TimeZone { get; set; }

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
