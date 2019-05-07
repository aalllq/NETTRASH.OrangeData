using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Organization
{
    public class Get : Base
    {
        #region Public properties



        public string Id { get; set; }



        #endregion
        #region Public constructors



        public Get()
        {
        }

        public Get(string sId)
        {
            Id = sId;
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/{Id}";
        }

        public override HttpContent GetContent()
        {
            return new StringContent(string.Empty);
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Get;
        }



        #endregion
    }
}
