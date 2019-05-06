using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Organization
{
    public class Change : Add
    {
        #region Public constructors



        public Change()
            : base()
        {
        }

        public Change(Classes.Organization.OrganizationData organization)
            : base(organization)
        {
        }



        #endregion
        #region Public methods



        public override HttpMethod GetMethod()
        {
            return HttpMethod.Put;
        }



        #endregion
    }
}
