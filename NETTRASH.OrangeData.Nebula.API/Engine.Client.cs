using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NETTRASH.OrangeData.Nebula.API
{
    public partial class Engine
    {
        #region Public methods



        public async Task<Result<Response.Client.List>> ListAsync(Request.Client.List request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Client.List value = Response.Client.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Client.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Client.List>(response.StatusCode, value);
        }

        public async Task<Result<Response.Client.Add>> AddAsync(Request.Client.Add request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Client.Add value = Response.Client.Add.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Client.Add.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Client.Add>(response.StatusCode, value);
        }

        public async Task<Result<Response.Client.Change>> ChangeAsync(Request.Client.Change request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Client.Change value = Response.Client.Change.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Client.Change.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Client.Change>(response.StatusCode, value);
        }

        public async Task<Result<Response.Client.Delete>> DeleteAsync(Request.Client.Delete request)
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
            return new Result<Response.Client.Delete>(response.StatusCode, Response.Client.Delete.Load(response.StatusCode));
        }

        public async Task<Result<Response.Client.Get>> GetAsync(Request.Client.Get request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Client.Get value = Response.Client.Get.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Client.Get.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Client.Get>(response.StatusCode, value);
        }

        public async Task<Result<Response.Client.List>> GetAsync(Request.Client.GetByOrganization request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Client.List value = Response.Client.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Client.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Client.List>(response.StatusCode, value);
        }



        #endregion
    }
}
