using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class CheckConnection : Base
    {
        #region Public properties



        public string Id { get; set; }



        #endregion
        #region Public constructors



        public CheckConnection()
            : base()
        {
        }

        public CheckConnection(string sId)
        {
            Id = sId;
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/checkConnection/{Id}";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(string.Empty);
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Post;
        }



        #endregion
    }
}
