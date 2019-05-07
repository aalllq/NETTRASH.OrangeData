using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NETTRASH.OrangeData.Nebula.API
{
    public partial class Engine
    {
        #region Public methods



        public async Task<Result<Response.DeviceGroup.List>> ListAsync(Request.DeviceGroup.List request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.DeviceGroup.List value = Response.DeviceGroup.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.DeviceGroup.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.DeviceGroup.List>(response.StatusCode, value);
        }

        public async Task<Result<Response.DeviceGroup.Add>> AddAsync(Request.DeviceGroup.Add request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.DeviceGroup.Add value = Response.DeviceGroup.Add.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.DeviceGroup.Add.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.DeviceGroup.Add>(response.StatusCode, value);
        }

        public async Task<Result<Response.DeviceGroup.Change>> ChangeAsync(Request.DeviceGroup.Change request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.DeviceGroup.Change value = Response.DeviceGroup.Change.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.DeviceGroup.Change.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.DeviceGroup.Change>(response.StatusCode, value);
        }

        public async Task<Result<Response.DeviceGroup.Delete>> DeleteAsync(Request.DeviceGroup.Delete request)
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
            return new Result<Response.DeviceGroup.Delete>(response.StatusCode, Response.DeviceGroup.Delete.Load(response.StatusCode));
        }

        public async Task<Result<Response.DeviceGroup.Get>> GetAsync(Request.DeviceGroup.Get request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.DeviceGroup.Get value = Response.DeviceGroup.Get.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.DeviceGroup.Get.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.DeviceGroup.Get>(response.StatusCode, value);
        }

        public async Task<Result<Response.DeviceGroup.List>> GetAsync(Request.DeviceGroup.GetByOrganization request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.DeviceGroup.List value = Response.DeviceGroup.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.DeviceGroup.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.DeviceGroup.List>(response.StatusCode, value);
        }



        #endregion
    }
}
