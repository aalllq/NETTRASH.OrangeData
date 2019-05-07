using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NETTRASH.OrangeData.Nebula.API
{
    public partial class Engine
    {
        #region Public methods



        public async Task<Result<Response.Organization.List>> ListAsync(Request.Organization.List request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Organization.List value = Response.Organization.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Organization.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Organization.List>(response.StatusCode, value);
        }

        public async Task<Result<Response.Organization.Add>> AddAsync(Request.Organization.Add request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Organization.Add value = Response.Organization.Add.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Organization.Add.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Organization.Add>(response.StatusCode, value);
        }

        public async Task<Result<Response.Organization.Change>> ChangeAsync(Request.Organization.Change request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Organization.Change value = Response.Organization.Change.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Organization.Change.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Organization.Change>(response.StatusCode, value);
        }

        public async Task<Result<Response.Organization.Delete>> DeleteAsync(Request.Organization.Delete request)
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
            return new Result<Response.Organization.Delete>(response.StatusCode, Response.Organization.Delete.Load(response.StatusCode));
        }

        public async Task<Result<Response.Organization.Get>> GetAsync(Request.Organization.Get request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Organization.Get value = Response.Organization.Get.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Organization.Get.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Organization.Get>(response.StatusCode, value);
        }

        public async Task<Result<Response.Organization.Get>> GetAsync(Request.Organization.GetByINN request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Organization.Get value = Response.Organization.Get.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.Organization.Get.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.Organization.Get>(response.StatusCode, value);
        }



        #endregion
    }
}
