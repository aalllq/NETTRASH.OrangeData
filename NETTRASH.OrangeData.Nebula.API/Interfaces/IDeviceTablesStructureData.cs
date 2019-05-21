namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceTablesStructureData
    {
        #region Public properties



        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        /// <value>Строка</value>
        string SerialNumber { get; set; }

        /// <summary>
        /// Описания таблиц
        /// </summary>
        /// <value>Массив структур</value>
        IDeviceTableStructureInfo[] Tables { get; set; }



        #endregion
    }
}
