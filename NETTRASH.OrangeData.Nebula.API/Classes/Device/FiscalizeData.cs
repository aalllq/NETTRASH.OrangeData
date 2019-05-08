using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Classes.Device
{
    [JsonObject]
    public class FiscalizeData : Interfaces.IDeviceFiscalizeData
    {
        #region Public properties



        /// <summary>
        /// Адрес сервера ОФД
        /// </summary>
        /// <value>Строка от 3 до 128 символов</value>
        [JsonProperty(PropertyName = "ofdServerAddress")]
        public string OFDServerAddress { get; set; }

        /// <summary>
        /// Порт сервера ОФД
        /// </summary>
        /// <value>Число</value>
        [JsonProperty(PropertyName = "ofdServerPort")]
        public int OFDServerPort { get; set; }

        /// <summary>
        /// Имя ОФД
        /// </summary>
        /// <value>Строка от 1 до 256 символов</value>
        [JsonProperty(PropertyName = "ofdName")]
        public string OFDName { get; set; }

        /// <summary>
        /// URL ОФД
        /// </summary>
        /// <value>Строка от 3 до 128 символов</value>
        [JsonProperty(PropertyName = "ofdurl")]
        public string OFDURL { get; set; }

        /// <summary>
        /// ИНН ОФД
        /// </summary>
        /// <value>Строка 10 или 12 символов</value>
        [JsonProperty(PropertyName = "ofdinn")]
        public string OFDINN { get; set; }

        /// <summary>
        /// URL налогового органа
        /// </summary>
        /// <value>Строка от 3 до 250 символов</value>
        [JsonProperty(PropertyName = "fiscalBodyURL")]
        public string NALOGURL { get; set; }

        /// <summary>
        /// Имя оператора, проводящего фискализацию
        /// </summary>
        /// <value>Строка до 128 символов</value>
        [JsonProperty(PropertyName = "operatorName")]
        public string Operator { get; set; }

        /// <summary>
        /// Регистрационный номер ККТ (РНМ)
        /// </summary>
        /// <value>Строка от 6 до 30 символов, необязательное поле</value>
        [JsonProperty(PropertyName = "rnm")]
        public string KKTRegistrationNumber { get; set; }

        /// <summary>
        /// Система налогообложения
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "kkmTaxSystem")]
        public TaxSystemEnumeration? TaxSystem { get; set; }

        /// <summary>
        /// Номер автомата, в котором установлена ККМ, работающая в автоматическом режиме
        /// </summary>
        /// <value>Строка от 1 до 30 символов</value>
        [JsonProperty(PropertyName = "automatonNumber")]
        public string AutomatonNumber { get; set; }

        /// <summary>
        /// URL интернет-магазина, в котором будет использоваться касса
        /// </summary>
        /// <value>Строка от 3 до 256 символов</value>
        [JsonProperty(PropertyName = "onlineStoreURL")]
        public string ShopURL { get; set; }

        /// <summary>
        /// Тип фискализации:
        ///   0 или не указан - первая фискализация;
        ///   1 - перефискализация в связи с измене-нием параметров с заменой ФН;
        ///   2 - перефискализация в связи с измене-нием параметров без замены ФН
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "fiscalizationMode")]
        public FiscalizationModeEnumeration? FiscalizationMode { get; set; }

        /// <summary>
        /// Причина перефискализации, отправля-ется в ОФД. Указывается, если FiscalizationMode указан и не равен 0:
        ///   1- Замена ФН;
        ///   2 - Замена ОФД;
        ///   3 - Изменение реквизитов;
        ///   4 - Изменение настроек ККТ
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "refiscalizationReason")]
        public RefiscalizationReasonEnumeration? RefiscalizationReason { get; set; }

        /// <summary>
        /// Режим работы ККТ при фискалзации
        /// 
        /// Битовая маска
        ///   0 – Шифрование
        ///   1 – Автономный режим
        ///   2 – Автоматический режим
        ///   3 – Применение в сфере услуг
        ///   4 – Режим БСО
        ///   5 – Применение в интернет
        /// </summary>
        /// <value>Число от 1 до 63 (битовая маска), необязательное поле</value>
        [JsonProperty(PropertyName = "operationMode")]
        public int? OperationMode { get; set; }

        /// <summary>
        /// Признак агента
        /// 
        /// Битовая маска
        ///   0 – банковский платежный агент
        ///   1 – банковский платежный субагент
        ///   2 – платежный агент
        ///   3 – платежный субагент
        ///   4 – поверенный
        ///   5 – комиссионер
        ///   6 – иной агент
        /// </summary>
        /// <value>Число от 1 до 127 (битовая маска), необязательное поле</value>
        [JsonProperty(PropertyName = "agentType")]
        public int? AgentType { get; set; }

        /// <summary>
        /// Электронный адрес отправителя
        /// </summary>
        /// <value>Строка</value>
        [JsonProperty(PropertyName = "senderEmail")]
        public string SenderEMail { get; set; }



        #endregion
        #region Public constructors



        public FiscalizeData()
        {
        }



        #endregion
    }
}
