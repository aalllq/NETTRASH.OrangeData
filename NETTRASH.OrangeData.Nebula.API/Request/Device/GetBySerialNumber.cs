using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class GetBySerialNumber : Base
    {
        #region Public properties



        public string Id { get; set; }



        #endregion
        #region Public constructors



        public GetBySerialNumber()
        {
        }

        public GetBySerialNumber(string sId)
        {
            Id = sId;
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/getBySerialNumber/{Id}";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(string.Empty);
        }



        #endregion
    }
}
