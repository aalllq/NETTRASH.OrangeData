using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class FDWarningFlagsInfo : Interfaces.IDeviceFDWarningFlagsInfo
    {
        #region Public properties



        /// <summary>
        /// Значение
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "value")]
        public int? Value { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }



        #endregion
        #region Public constructors



        public FDWarningFlagsInfo()
        {
        }

        public FDWarningFlagsInfo(Interfaces.IDeviceFDWarningFlagsInfo warning)
        {
            Value = warning.Value;
            Description = warning.Description;
        }



        #endregion
    }
}
