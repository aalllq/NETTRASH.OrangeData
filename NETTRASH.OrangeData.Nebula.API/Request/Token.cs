using System.Collections.Generic;
using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request
{
    public class Token : Base
    {
        #region Public properties



        public string Login { get; set; }

        public string Password { get; set; }



        #endregion
        #region Public constructors



        public Token()
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/token";
        }

        public override HttpContent GetContent()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("grant_type", "password");
            parameters.Add("username", Login);
            parameters.Add("password", Password);
            return new FormUrlEncodedContent(parameters);
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Post;
        }


        #endregion
    }
}
