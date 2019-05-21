namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceTableStructureInfo
    {
        #region Public properties



        /// <summary>
        /// Название таблицы
        /// </summary>
        /// <value>Строка</value>
        string Name { get; set; }

        /// <summary>
        /// Номер таблицы
        /// </summary>
        /// <value>Число</value>
        int Number { get; set; }

        /// <summary>
        /// Количество колонок
        /// </summary>
        /// <value>Число</value>
        int Columns { get; set; }

        /// <summary>
        /// Количество строк
        /// </summary>
        /// <value>Число</value>
        int Rows { get; set; }



        #endregion
    }
}
