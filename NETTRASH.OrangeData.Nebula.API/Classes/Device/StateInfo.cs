using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class StateInfo : Interfaces.IDeviceStateInfo
    {
        #region Private properties



        private FDWarningFlagsInfo _warningFlags { get; set; }

        private ErrorInfo _error { get; set; }



        #endregion
        #region Public properties



        /// <summary>
        /// Сетевой адрес устройства (IP)
        /// </summary>
        /// <value>Строка 15 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "networkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// MAC адрес устройства
        /// </summary>
        /// <value>Строка 17 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "macAddress")]
        public string MACAddress { get; set; }

        /// <summary>
        /// Серийный номер фискального накопителя
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "fsSerialNumber")]
        public string FDSerialNumber { get; set; }

        /// <summary>
        /// Флаги предупреждения фискального накопителя
        /// </summary>
        /// <value>Структура</value>
        [JsonProperty(PropertyName = "fsWarningFlags")]
        public Interfaces.IDeviceFDWarningFlagsInfo FDWarningFlags
        {
            get
            {
                return _warningFlags;
            }

            set
            {
                _warningFlags = new FDWarningFlagsInfo(value);
            }
        }

        /// <summary>
        /// Количество документов обработанных фискальным накопителем
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "fsDocumentsCount")]
        public int? FDDocumentsCount { get; set; }

        /// <summary>
        /// Дата и время фискализации для определения срока истечения
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "fiscalizedAt")]
        public string FiscalizedAt { get; set; }

        /// <summary>
        /// Количество неотправленных документов
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "unsentDocumentsCount")]
        public int? UnsentDocumentsCount { get; set; }

        /// <summary>
        /// Дата и время создания самого старого неотправленного докумен-та
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        [JsonProperty(PropertyName = "oldestUnsentDocumentCreatedAt")]
        public string OldestUnsentDocumentCreatedAt { get; set; }

        /// <summary>
        /// Ошибка устройства
        /// </summary>
        /// <value>Структура</value>
        [JsonProperty(PropertyName = "error")]
        public Interfaces.IDeviceErrorInfo Errors
        {
            get
            {
                return _error;
            }

            set
            {
                _error = new ErrorInfo(value);
            }
        }

        /// <summary>
        /// Дата прошивки устройства
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "firmwareDate")]
        public int? FirmwareDate { get; set; }

        /// <summary>
        /// Версия прошивки устройства
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "firmwareVersion")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Билд прошивки устройства
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "firmwareBuild")]
        public int? FirmwareBuild { get; set; }



        #endregion
        #region Public constructors



        public StateInfo()
        {
        }

        public StateInfo(Interfaces.IDeviceStateInfo state)
        {
            NetworkAddress = state.NetworkAddress;
            MACAddress = state.MACAddress;
            FDSerialNumber = state.FDSerialNumber;
            FDWarningFlags = state.FDWarningFlags;
            FDDocumentsCount = state.FDDocumentsCount;
            FiscalizedAt = state.FiscalizedAt;
            UnsentDocumentsCount = state.UnsentDocumentsCount;
            OldestUnsentDocumentCreatedAt = state.OldestUnsentDocumentCreatedAt;
            Errors = state.Errors;
            FirmwareDate = state.FirmwareDate;
            FirmwareVersion = state.FirmwareVersion;
            FirmwareBuild = state.FirmwareBuild;
        }



        #endregion
    }
}
