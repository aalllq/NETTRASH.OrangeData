using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NETTRASH.OrangeData.Nebula.API
{
    /// <summary>
    /// Engine.
    /// Коды ответа надо воспринимать так:
    /// 200 - запрос обработан, в ответ направлены данные с сервера
    /// 201 - запрос успешно обработан, запрашиваемая сущность создана
    /// 204 - запрос обработан успешно, сущность удалена
    /// 400 - входящие данные содержать ошибку
    /// 401 - переданные в запросе токен протух, нужно снова запросить авторизацию в системе
    /// 404 - не найдена сущность в запросе
    /// </summary>
    public class Engine
    {
        #region Private properties



        private string _Login { get; set; }

        private string _Password { get; set; }

        private string _TokenData { get; set; }



        #endregion
        #region Public properties



        public string Host { get; set; }

        public uint Port { get; set; }

        public bool IsSecure { get; set; }

        public bool AutoReNewAuthToken { get; set; }



        #endregion
        #region Public constructors



        public Engine(string sHost, uint nPort = 8001, bool bIsSecure = true, bool bAutoReNewAuthToken = true)
        {
            Host = sHost;
            Port = nPort;
            IsSecure = bIsSecure;
            AutoReNewAuthToken = bAutoReNewAuthToken;
        }



        #endregion
        #region Private methods



        private async Task<HttpResponseMessage> CallAsync(HttpRequestMessage message)
        {
            HttpClient http = new HttpClient();
            return await http.SendAsync(message);
        }



        #endregion
        #region Public methods



        /// <summary>
        /// Получечние токена доступа
        /// </summary>
        /// <returns>Результат запроса и токен доступа при успешном запросе</returns>
        /// <param name="request">Данные для аутентификации</param>
        public async Task<Result<Response.Token>> TokenGetAsync(Request.Token request)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Content = request.GetContent();
            message.Method = request.GetMethod();
            message.RequestUri = new Uri($"http{(IsSecure ? "s" : string.Empty)}://{Host}:{Port}{request.GetURLPart()}");
            HttpResponseMessage response = await CallAsync(message);
            Response.Token token = Response.Token.Load(await response.Content.ReadAsStringAsync());
            if (AutoReNewAuthToken && response.StatusCode.Equals(200))
            {
                _Login = request.Login;
                _Password = request.Password;
                _TokenData = token.Data;
            }
            return new Result<Response.Token>(response.StatusCode, token);
        }

        public async Task<Result<Response.Organization.List>> OrganizationListAsync(Request.Organization.List request)
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

        public async Task<Result<Response.Organization.Add>> OrganizationAddAsync(Request.Organization.Add request)
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

        public async Task<Result<Response.Organization.Change>> OrganizationChangeAsync(Request.Organization.Change request)
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

        public async Task<Result<Response.Organization.Delete>> OrganizationDeleteAsync(Request.Organization.Delete request)
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

        public async Task<Result<Response.Organization.Get>> OrganizationGetAsync(Request.Organization.Get request)
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

        public async Task<Result<Response.Organization.Get>> OrganizationGetAsync(Request.Organization.GetByINN request)
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
