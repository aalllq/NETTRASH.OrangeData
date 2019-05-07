using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.User
{
    public class Add : Base
    {
        #region Public properties



        public Classes.User.UserData User { get; set; }



        #endregion
        #region Public constructors



        public Add()
        {
            User = null;
        }

        public Add(Classes.User.UserData user)
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
            return HttpMethod.Post;
        }



        #endregion
    }
}
