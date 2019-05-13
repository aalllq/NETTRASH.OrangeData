using System.Net.Http;
using NETTRASH.OrangeData.Nebula.API.Classes.Device;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device.Table
{
    public class Get : BaseSpecific
    {
        #region Public properties



        public TableListData Tables { get; set; }



        #endregion
        #region Public constructors



        public Get(string sId, TableListData tables)
            : base(sId)
        {
            Tables = tables;
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/readTables";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Tables), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Post;
        }



        #endregion
    }
}
