using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Client
{
    public class Change : Base
    {
        #region Public properties



        public Classes.Client.ClientInfo Client { get; set; }



        #endregion
        #region Public constructors



        public Change()
        {
            Client = null;
        }

        public Change(Classes.Client.ClientInfo client)
        {
            Client = client;
        }



        #endregion
        #region Public methods



        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Client), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Put;
        }



        #endregion
    }
}
