using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Client
{
    public class Add : Base
    {
        #region Public properties



        public Classes.Client.ClientData Client { get; set; }



        #endregion
        #region Public constructors



        public Add()
        {
            Client = null;
        }

        public Add(Classes.Client.ClientData client)
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
            return HttpMethod.Post;
        }



        #endregion
    }
}
