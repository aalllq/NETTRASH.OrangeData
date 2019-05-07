using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Response.User
{
    [JsonObject]
    public class Get : Add, Interfaces.IUserInfo
    {
        #region Public constructors



        public Get()
            : base()
        {
        }



        #endregion
        #region Public methods



        new public static Get Load(string sSourceJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Get>(sSourceJson);
            }
            catch
            {
                return null;
            }
        }



        #endregion
    }
}
