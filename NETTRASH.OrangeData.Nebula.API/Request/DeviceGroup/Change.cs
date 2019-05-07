using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.DeviceGroup
{
    public class Change : Add
    {
        #region Public constructors



        public Change()
            : base()
        {
        }

        public Change(Classes.DeviceGroup.DeviceGroupData deviceGroup)
            : base(deviceGroup)
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
