using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.User
{
    public class Change : Base
    {
        #region Public properties



        public Classes.User.UserInfo User { get; set; }



        #endregion
        #region Public constructors



        public Change()
        {
            User = null;
        }

        public Change(Classes.User.UserInfo user)
        {
            User = user;
        }



        #endregion
        #region Public methods



        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(User), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Put;
        }



        #endregion
    }
}
