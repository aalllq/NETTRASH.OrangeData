using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class Free : Base
    {
        #region Public constructors



        public Free()
            : base()
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/vacant";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(string.Empty);
        }



        #endregion
    }
}
