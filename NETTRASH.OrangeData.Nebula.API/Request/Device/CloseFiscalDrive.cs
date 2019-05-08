using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class CloseFiscalDrive : BaseSpecific
    {
        #region Public constructors



        public CloseFiscalDrive(string sId)
            : base(sId)
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/closeFS";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(string.Empty);
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Put;
        }



        #endregion
    }
}
