using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.OrganizationKey
{
    [JsonObject]
    public class OrganizationKeyInfo : OrganizationKeyData, Interfaces.IOrganizationKeyInfo
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



        #endregion
        #region Public constructors



        public OrganizationKeyInfo()
        {
        }



        #endregion
    }
}
