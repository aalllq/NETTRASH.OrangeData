using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class BaseSpecific : Base
    {
        #region Public properties



        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }



        #endregion
        #region Public constructors



        public BaseSpecific(string sId)
            : base()
        {
            Id = sId;
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/{Id}";
        }



        #endregion
    }
}
