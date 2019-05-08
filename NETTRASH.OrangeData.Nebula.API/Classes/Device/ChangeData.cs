using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class ChangeData : Interfaces.IDeviceChangeData
    {
        #region Public properties



        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор группы устройств
        /// </summary>
        /// <value>Строка от 1 до 32 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "deviceGroupId")]
        public string DeviceGroupId { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «false» - устройство активно;
        ///   «true» - устройствозаблокировано
        /// </summary>
        /// <value>Логическое</value>
        [JsonProperty(PropertyName = "blocked")]
        public bool IsBlocked { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Автоматическое закрытие смены, секунды от начала дня, либо «null», тогда смена будет закрываться по истечению 24 часов
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "autoCloseShiftAt")]
        public int? AutoCloseShiftAt { get; set; }



        #endregion
        #region Public constructors



        public ChangeData()
        {
        }



        #endregion
    }
}
