using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Response.OrganizationKey
{
    [JsonObject]
    public class Change : Add, Interfaces.IOrganizationKeyInfo
    {
        #region Public constructors



        public Change()
            : base()
        {
        }



        #endregion
        #region Public methods



        new public static Change Load(string sSourceJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Change>(sSourceJson);
            }
            catch
            {
                return null;
            }
        }



        #endregion
    }
}
