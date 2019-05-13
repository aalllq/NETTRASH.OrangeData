using System.Net.Http;
using NETTRASH.OrangeData.Nebula.API.Classes.Device;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device.Table
{
    [JsonObject]
    public class Cell : BaseSpecific
    {
        #region Public properties



        public CellPositionData CellPosition { get; set; }



        #endregion
        #region Public constructors



        public Cell(string sId, CellPositionData cell)
            : base(sId)
        {
            CellPosition = cell;
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/readTable";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(CellPosition), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Post;
        }



        #endregion
    }
}
