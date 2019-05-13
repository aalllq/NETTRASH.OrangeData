namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceStateInfo
    {
        #region Public properties



        /// <summary>
        /// Сетевой адрес устройства (IP)
        /// </summary>
        /// <value>Строка 15 символов, необязательное поле</value>
        string NetworkAddress { get; set; }

        /// <summary>
        /// MAC адрес устройства
        /// </summary>
        /// <value>Строка 17 символов, необязательное поле</value>
        string MACAddress { get; set; }

        /// <summary>
        /// Серийный номер фискального накопителя
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string FDSerialNumber { get; set; }

        /// <summary>
        /// Флаги предупреждения фискального накопителя
        /// </summary>
        /// <value>Структура</value>
        IFDWarningFlagsInfo FDWarningFlags { get; set; }

        /// <summary>
        /// Количество документов обработанных фискальным накопителем
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? FDDocumentsCount { get; set; }

        /// <summary>
        /// Дата и время фискализации для определения срока истечения
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string FiscalizedAt { get; set; }

        /// <summary>
        /// Количество неотправленных документов
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? UnsentDocumentsCount { get; set; }

        /// <summary>
        /// Дата и время создания самого старого неотправленного докумен-та
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string OldestUnsentDocumentCreatedAt { get; set; }

        /// <summary>
        /// Ошибка устройства
        /// </summary>
        /// <value>Структура</value>
        IDeviceErrorInfo Errors { get; set; }

        /// <summary>
        /// Дата прошивки устройства
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? FirmwareDate { get; set; }

        /// <summary>
        /// Версия прошивки устройства
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string FirmwareVersion { get; set; }

        /// <summary>
        /// Билд прошивки устройства
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? FirmwareBuild { get; set; }



        #endregion
    }
}
