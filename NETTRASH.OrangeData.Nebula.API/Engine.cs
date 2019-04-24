using System;
using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API
{
    public class Engine
    {
        #region Public properties



        public string Host { get; set; }

        public uint Port { get; set; }

        public bool IsSecure { get; set; }



        #endregion
        #region Public constructors



        public Engine(string sHost, uint nPort, bool bIsSecure)
        {
            Host = sHost;
            Port = nPort;
            IsSecure = bIsSecure;
        }



        #endregion
        #region Public methods



        public async Task<Result<Response.Token>> GetTokenAsync(Request.Token request)
        {
            HttpClient http = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            return null;
        }



        #endregion
    }
}
