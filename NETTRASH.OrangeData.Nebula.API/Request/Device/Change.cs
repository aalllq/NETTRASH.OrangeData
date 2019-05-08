using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class Change : Base
    {
        #region Public properties



        public Classes.Device.ChangeData Data { get; set; }



        #endregion
        #region Public constructors



        public Change()
        {
            Data = null;
        }

        public Change(Classes.Device.ChangeData data)
        {
            Data = data;
        }



        #endregion
        #region Public methods



        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Data), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Put;
        }



        #endregion
    }
}
