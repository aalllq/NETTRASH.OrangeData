using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class CloseShift : BaseSpecific
    {
        #region Public constructors



        public CloseShift(string sId)
            : base(sId)
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/closeShift";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(string.Empty);
        }



        #endregion
    }
}
