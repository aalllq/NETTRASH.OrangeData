using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.User
{
    [JsonObject]
    public class UserInfo : UserBase, Interfaces.IUserInfo
    {
        #region Public properties



        /// <summary>
        /// Время добавления пользователя в БД. Проставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "dateAdded")]
        public string CreateDate { get; set; }



        #endregion
        #region Public constructors



        public UserInfo()
            : base()
        {
        }



        #endregion
    }
}
