using System.Net.Http;
using NETTRASH.OrangeData.Nebula.API.Classes.Device;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device.Table
{
    public class Set : BaseSpecific
    {
        #region Public properties



        public CellValueData CellValue { get; set; }



        #endregion
        #region Public constructors



        public Set(string sId, CellValueData cell)
            : base(sId)
        {
            CellValue = cell;
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/writeTables";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(CellValue), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Post;
        }



        #endregion
    }
}
