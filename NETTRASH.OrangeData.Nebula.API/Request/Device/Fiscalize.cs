using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class Fiscalize : BaseSpecific
    {
        #region Public properties



        public Classes.Device.FiscalizeData FiscalizeData { get; set; }



        #endregion
        #region Public constructors



        public Fiscalize(string sId, Classes.Device.FiscalizeData data)
            : base(sId)
        {
            FiscalizeData = data;
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/fiscalize";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(FiscalizeData), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Put;
        }



        #endregion
    }
}
