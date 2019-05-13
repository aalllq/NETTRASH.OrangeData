using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class ErrorInfo : Interfaces.IDeviceErrorInfo
    {
        #region Public properties



        /// <summary>
        /// Код ошибки, выданный устройством
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// Текстовое описание ошибки
        /// </summary>
        /// <value>Строка</value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }



        #endregion
        #region Public constructors



        public ErrorInfo()
        {
        }

        public ErrorInfo(Interfaces.IDeviceErrorInfo error)
        {
            Code = error.Code;
            Message = error.Message;
        }



        #endregion
    }
}
