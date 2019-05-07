using System.Net.Http;
using System.Threading.Tasks;

namespace NETTRASH.OrangeData.Nebula.API
{
    public partial class Engine
    {
        #region Public methods



        public async Task<Result<Response.OrganizationKey.List>> ListAsync(Request.OrganizationKey.List request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.OrganizationKey.List value = Response.OrganizationKey.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.OrganizationKey.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.OrganizationKey.List>(response.StatusCode, value);
        }

        public async Task<Result<Response.OrganizationKey.Add>> AddAsync(Request.OrganizationKey.Add request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.OrganizationKey.Add value = Response.OrganizationKey.Add.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.OrganizationKey.Add.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.OrganizationKey.Add>(response.StatusCode, value);
        }

        public async Task<Result<Response.OrganizationKey.Change>> ChangeAsync(Request.OrganizationKey.Change request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.OrganizationKey.Change value = Response.OrganizationKey.Change.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.OrganizationKey.Change.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.OrganizationKey.Change>(response.StatusCode, value);
        }

        public async Task<Result<Response.OrganizationKey.Delete>> DeleteAsync(Request.OrganizationKey.Delete request)
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
            return new Result<Response.OrganizationKey.Delete>(response.StatusCode, Response.OrganizationKey.Delete.Load(response.StatusCode));
        }

        public async Task<Result<Response.OrganizationKey.Get>> GetAsync(Request.OrganizationKey.Get request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.OrganizationKey.Get value = Response.OrganizationKey.Get.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.OrganizationKey.Get.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.OrganizationKey.Get>(response.StatusCode, value);
        }

        public async Task<Result<Response.OrganizationKey.List>> GetAsync(Request.OrganizationKey.GetByOrganization request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.OrganizationKey.List value = Response.OrganizationKey.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.OrganizationKey.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.OrganizationKey.List>(response.StatusCode, value);
        }

        public async Task<Result<Response.OrganizationKey.List>> GetAsync(Request.OrganizationKey.GetByDeviceGroup request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.OrganizationKey.List value = Response.OrganizationKey.List.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(401))
            {
                Result<Response.Token> res = await TokenGetAsync(new Request.Token(_Login, _Password));
                if (res.StatusCode.Equals(200))
                {
                    response = await CallAsync(message);
                    value = Response.OrganizationKey.List.Load(await response.Content.ReadAsStringAsync());
                }
            }
            return new Result<Response.OrganizationKey.List>(response.StatusCode, value);
        }



        #endregion
    }
}
