using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Request.Device
{
    [JsonObject]
    public class List : Base
    {
        #region Public constructors



        public List()
        {
        }



        #endregion
        #region Public methods



        public override HttpContent GetContent()
        {
            return new StringContent(string.Empty);
        }

        /// <summary>
        /// Возвращает объект для запроса
        /// </summary>
        /// <returns>Стандартный HttpContent наследник</returns>
        /// <param name="nCount">Максимальное количество элементов в выборке</param>
        /// <param name="sAfter">Указывается Id последнего элемента выборки</param>
        public HttpContent GetContent(int? nCount, string sAfter)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (nCount.HasValue)
                parameters.Add("count", nCount.Value.ToString());
            if (!string.IsNullOrEmpty(sAfter))
                parameters.Add("after", sAfter);
            return new FormUrlEncodedContent(parameters);
        }



        #endregion
    }
}
