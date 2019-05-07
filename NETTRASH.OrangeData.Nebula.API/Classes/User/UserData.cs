using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.User
{
    [JsonObject]
    public class UserData : UserBase, Interfaces.IUserData
    {
        #region Public properties



        /// <summary>
        /// Пароль
        /// </summary>
        /// <value>Строка до 6 символов</value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }



        #endregion
        #region Public constructors



        public UserData()
            : base()
        {
        }



        #endregion
    }
}
