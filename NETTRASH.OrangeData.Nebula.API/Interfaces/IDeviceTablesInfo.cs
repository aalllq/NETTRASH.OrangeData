namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceTablesInfo
    {
        #region Public properties



        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        /// <value>Строка</value>
        string SerialNumber { get; set; }

        /// <summary>
        /// Набор таблиц устройства
        /// </summary>
        /// <value>Массив структур</value>
        IDeviceTableData[] Tables { get; set; }



        #endregion
    }
}
