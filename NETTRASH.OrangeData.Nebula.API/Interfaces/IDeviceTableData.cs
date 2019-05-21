namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceTableData
    {
        #region Public properties



        /// <summary>
        /// Название таблицы.
        /// </summary>
        /// <value>Строка</value>
        string Name { get; set; }

        /// <summary>
        /// Номер таблицы
        /// </summary>
        /// <value>Число</value>
        int Number { get; set; }

        /// <summary>
        /// Ячейки
        /// </summary>
        /// <value>Массив структур</value>
        IDeviceCellInfoData[] Cells { get; set; }



        #endregion
    }
}
