namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceCellData : IDeviceCellInfoData
    {
        #region Public properties



        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string SerialNumber { get; set; }

        /// <summary>
        /// Наименование таблицы
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string TableName { get; set; }

        /// <summary>
        /// Номер таблицы
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? Table { get; set; }



        #endregion
    }
}
