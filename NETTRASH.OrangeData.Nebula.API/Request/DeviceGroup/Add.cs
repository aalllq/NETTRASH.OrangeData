using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.DeviceGroup
{
    public class Add : Base
    {
        #region Public properties



        public Classes.DeviceGroup.DeviceGroupData DeviceGroup { get; set; }



        #endregion
        #region Public constructors



        public Add()
        {
            DeviceGroup = null;
        }

        public Add(Classes.DeviceGroup.DeviceGroupData deviceGroup)
        {
            DeviceGroup = deviceGroup;
        }



        #endregion
        #region Public methods



        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(DeviceGroup), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Post;
        }



        #endregion
    }
}
}
