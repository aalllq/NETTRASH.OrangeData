using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Response.OrganizationKey
{
    [JsonObject]
    public class Add : Base, Interfaces.IOrganizationKeyInfo
    {
        #region Public properties



        /// <summary>
        /// Идентификатор ключа
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Дата добавления ключа в БД. Проставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "id")]
        public string CreateDate { get; set; }

        /// <summary>
        /// Идентификатор организации
        /// </summary>
        /// <value>Строка от 1 до 32 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "organizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Идентификатор группы, к которой привязан ключ
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Название ключа
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Тип ключа:
        ///   0 - SHA256-RSA;
        ///   1 - принимать документы без подпи-си
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "type")]
        public SignatureTypeEnumeration SignatureType { get; set; }



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
