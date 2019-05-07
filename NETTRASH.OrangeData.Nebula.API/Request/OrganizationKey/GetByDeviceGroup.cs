namespace NETTRASH.OrangeData.Nebula.API.Request.OrganizationKey
{
    public class GetByDeviceGroup : Get
    {
        #region Public constructors



        public GetByDeviceGroup()
            : base()
        {
        }

        public GetByDeviceGroup(string sDeviceGroupId)
            : base(sDeviceGroupId)
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart().Replace(Id, $"getByDeviceGroup/{Id}")}";
        }



        #endregion
    }
}
