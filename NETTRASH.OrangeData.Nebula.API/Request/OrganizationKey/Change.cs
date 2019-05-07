using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.OrganizationKey
{
    public class Change : Base
    {
        #region Public properties



        public Classes.OrganizationKey.OrganizationKeyInfo OrganizationKey { get; set; }



        #endregion
        #region Public constructors



        public Change()
        {
            OrganizationKey = null;
        }

        public Change(Classes.OrganizationKey.OrganizationKeyInfo key)
        {
            OrganizationKey = key;
        }



        #endregion
        #region Public methods



        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(OrganizationKey), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Put;
        }



        #endregion
    }
}
