using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device.Table
{
    public class Update : BaseSpecific
    {
        #region Public constructors



        public Update(string sId)
            : base(sId)
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/updateStoredTables";
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
