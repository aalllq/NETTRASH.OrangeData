using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Client
{
    public class Delete : Base
    {
        #region Public properties



        public string Id { get; set; }



        #endregion
        #region Public constructors



        public Delete()
        {
        }

        public Delete(string sId)
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
            return HttpMethod.Delete;
        }



        #endregion
    }
}
