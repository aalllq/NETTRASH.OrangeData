using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device.Table
{
    [JsonObject]
    public class List : BaseSpecific
    {
        #region Public constructors



        public List(string sId)
            : base(sId)
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/listTables";
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
