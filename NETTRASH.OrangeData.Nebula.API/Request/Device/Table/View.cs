using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device.Table
{
    public class View : BaseSpecific
    {
        #region Public constructors



        public View(string sId)
            : base(sId)
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/viewStoredTables";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(string.Empty);
        }



        #endregion
    }
}
