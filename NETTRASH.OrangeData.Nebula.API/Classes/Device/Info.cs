using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class Info : Interfaces.IDeviceInfo
    {
        #region Private properties



        private StateInfo _state { get; set; }



        #endregion
        #region Public properties



        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор группы, к которой привязано устройство
        /// </summary>
        /// <value>Строка от 1 до 32 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "deviceGroupId")]
        public string DeviceGroupId { get; set; }

        /// <summary>
        /// Название группы, к которой привязано устройство
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "deviceGroupName")]
        public string DeviceGroupName { get; set; }

        /// <summary>
        /// Идентификатор организации, к которой привязано устройство
        /// </summary>
        /// <value>Строка от 1 до 32 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "organizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Название организации, к которой привязано устройство
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "organizationName")]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        /// <value>Строка до 20 символов</value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «true» – устройство заблокировано;
        ///   «false» - устройство активно
        /// </summary>
        /// <value>Логический</value>
        [JsonProperty(PropertyName = "blocked")]
        public bool IsBlocked { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Текущее состояние
        /// </summary>
        /// <value>Структура</value>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StateInfo))]
        public Interfaces.IDeviceStateInfo State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = new StateInfo(value);
            }
        }

        /// <summary>
        /// Автоматическое закрытие смены, се-кунды от начала дня, либо «null», тогда смена будет закрываться по исте-чению 24 часов
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "autoCloseShiftAt")]
        public int? AutoCloseShiftAt { get; set; }



        #endregion
        #region Public constructors



        public Info()
        {
        }



        #endregion
    }
}
