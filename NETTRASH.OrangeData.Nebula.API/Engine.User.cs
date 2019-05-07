using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NETTRASH.OrangeData.Nebula.API
{
    public partial class Engine
    {
        #region Public methods



        public async Task<Result<Response.User.List>> ListAsync(Request.User.List request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.User.List value = Response.User.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.User.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.User.List>(response.StatusCode, value);
        }

        public async Task<Result<Response.User.Add>> AddAsync(Request.User.Add request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.User.Add value = Response.User.Add.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.User.Add.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.User.Add>(response.StatusCode, value);
        }

        public async Task<Result<Response.User.Change>> ChangeAsync(Request.User.Change request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.User.Change value = Response.User.Change.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.User.Change.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.User.Change>(response.StatusCode, value);
        }

        public async Task<Result<Response.User.Delete>> DeleteAsync(Request.Client.Delete request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                }
            }
            return new Result<Response.User.Delete>(response.StatusCode, Response.User.Delete.Load(response.StatusCode));
        }

        public async Task<Result<Response.User.Get>> GetAsync(Request.User.Get request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.User.Get value = Response.User.Get.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.User.Get.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.User.Get>(response.StatusCode, value);
        }



        #endregion
    }
}
