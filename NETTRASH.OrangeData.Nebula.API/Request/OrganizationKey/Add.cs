using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.OrganizationKey
{
    public class Add : Base
    {
        #region Public properties



        public Classes.OrganizationKey.OrganizationKeyData OrganizationKey { get; set; }



        #endregion
        #region Public constructors



        public Add()
        {
            OrganizationKey = null;
        }

        public Add(Classes.OrganizationKey.OrganizationKeyData key)
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
            return HttpMethod.Post;
        }



        #endregion
    }
}
