using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Response
{
    [JsonObject]
    public class Token : Base
    {
        #region Public properties



        [JsonProperty(PropertyName = "access_token")]
        public string Data { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public uint Expires { get; set; }



        #endregion
        #region Public constructors



        public Token()
        {
        }



        #endregion
        #region Public methods



        public static Token Load(string sSourceJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Token>(sSourceJson);
            }
            catch
            {
                return null;
            }
        }



        #endregion
    }
}
