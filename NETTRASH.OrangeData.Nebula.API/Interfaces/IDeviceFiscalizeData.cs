﻿namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceFiscalizeData
    {
        #region Public properties



        /// <summary>
        /// Адрес сервера ОФД
        /// </summary>
        /// <value>Строка от 3 до 128 символов</value>
        string OFDServerAddress { get; set; }

        /// <summary>
        /// Порт сервера ОФД
        /// </summary>
        /// <value>Число</value>
        int OFDServerPort { get; set; }

        /// <summary>
        /// Имя ОФД
        /// </summary>
        /// <value>Строка от 1 до 256 символов</value>
        string OFDName { get; set; }

        /// <summary>
        /// URL ОФД
        /// </summary>
        /// <value>Строка от 3 до 128 символов</value>
        string OFDURL { get; set; }

        /// <summary>
        /// ИНН ОФД
        /// </summary>
        /// <value>Строка 10 или 12 символов</value>
        string OFDINN { get; set; }

        /// <summary>
        /// URL налогового органа
        /// </summary>
        /// <value>Строка от 3 до 250 символов</value>
        string NALOGURL { get; set; }

        /// <summary>
        /// Имя оператора, проводящего фискализацию
        /// </summary>
        /// <value>Строка до 128 символов</value>
        string Operator { get; set; }

        /// <summary>
        /// Регистрационный номер ККТ (РНМ)
        /// </summary>
        /// <value>Строка от 6 до 30 символов, необязательное поле</value>
        string KKTRegistrationNumber { get; set; }

        /// <summary>
        /// Система налогообложения
        /// </summary>
        /// <value>Число, необязательное поле</value>
        TaxSystemEnumeration? TaxSystem { get; set; }

        /// <summary>
        /// Номер автомата, в котором установлена ККМ, работающая в автоматическом режиме
        /// </summary>
        /// <value>Строка от 1 до 30 символов</value>
        string AutomatonNumber { get; set; }

        /// <summary>
        /// URL интернет-магазина, в котором будет использоваться касса
        /// </summary>
        /// <value>Строка от 3 до 256 символов</value>
        string ShopURL { get; set; }

        /// <summary>
        /// Тип фискализации:
        ///   0 или не указан - первая фискализация;
        ///   1 - перефискализация в связи с измене-нием параметров с заменой ФН;
        ///   2 - перефискализация в связи с измене-нием параметров без замены ФН
        /// </summary>
        /// <value>Число, необязательное поле</value>
        FiscalizationModeEnumeration? FiscalizationMode { get; set; }

        /// <summary>
        /// Причина перефискализации, отправля-ется в ОФД. Указывается, если FiscalizationMode указан и не равен 0:
        ///   1- Замена ФН;
        ///   2 - Замена ОФД;
        ///   3 - Изменение реквизитов;
        ///   4 - Изменение настроек ККТ
        /// </summary>
        /// <value>Число, необязательное поле</value>
        RefiscalizationReasonEnumeration? RefiscalizationReason { get; set; }

        /// <summary>
        /// Режим работы ККТ при фискалзации
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? OperationMode { get; set; }

        /// <summary>
        /// Признак агента
        /// </summary>
        /// <value>Ччисло, необязательное поле</value>
        int? AgentType { get; set; }

        /// <summary>
        /// Электронный адрес отправителя
        /// </summary>
        /// <value>Строка</value>
        string SenderEMail { get; set; }



        #endregion
    }
}
