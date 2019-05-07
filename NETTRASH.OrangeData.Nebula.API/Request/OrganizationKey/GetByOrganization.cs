namespace NETTRASH.OrangeData.Nebula.API.Request.OrganizationKey
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



        #endregion
    }
}
