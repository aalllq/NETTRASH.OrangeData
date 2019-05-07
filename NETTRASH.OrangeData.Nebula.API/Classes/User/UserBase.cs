using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.User
{
    [JsonObject]
    public class UserBase : Interfaces.IUserBase
    {
        #region Public properties



        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор организации
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        [JsonProperty(PropertyName = "organizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Уникальное имя пользователя (логин)
        /// </summary>
        /// <value>Строка до 66 символов</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Полное имя пользователя
        /// </summary>
        /// <value>Строка до 128 сим-волов</value>
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        /// <value>Строка до 256 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "email")]
        public string EMail { get; set; }

        /// <summary>
        /// Разрешение фискализировать:
        ///   «false» - фискализировать ФН запрещено;
        ///   «true» - фискализировать ФН разрешено
        /// </summary>
        /// <value>Логическое</value>
        [JsonProperty(PropertyName = "canFiscalize")]
        public bool Fiscalize { get; set; }

        /// <summary>
        /// Разрешение мониторить:
        ///   «false» - мониторить систему запрещено;
        ///   «true» - мониторить систему разрешено
        /// </summary>
        /// <value>Логическое</value>
        [JsonProperty(PropertyName = "canMonitor")]
        public bool Monitor { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «false» - пользователь не заблокирован;
        ///   «true» - пользователь заблокирован
        /// </summary>
        /// <value>Логическое</value>
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



        public UserBase()
        {
        }



        #endregion
    }
}
