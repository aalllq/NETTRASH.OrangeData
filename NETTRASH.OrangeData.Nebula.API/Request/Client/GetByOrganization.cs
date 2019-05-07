using System.Collections.Generic;
using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Client
{
    public class GetByOrganization : Get
    {
        #region Public constructors



        public GetByOrganization()
            : base()
        {
        }

        public GetByOrganization(string sOrganizationId)
            : base(sOrganizationId)
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart().Replace(Id, $"GetByOrganization/{Id}")}";
        }

        public HttpContent GetContent(int? nCount, string sAfter)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (nCount.HasValue)
                parameters.Add("count", nCount.Value.ToString());
            if (!string.IsNullOrEmpty(sAfter))
                parameters.Add("after", sAfter);
            return new FormUrlEncodedContent(parameters);
        }



        #endregion
    }
}
