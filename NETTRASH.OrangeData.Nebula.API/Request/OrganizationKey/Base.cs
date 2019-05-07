using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.OrganizationKey
{
    [JsonObject]
    public class Base : Request.Base
    {
        #region Public constructors



        public Base()
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/organizationKeys";
        }



        #endregion
    }
}
