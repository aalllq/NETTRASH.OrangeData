namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceCellPositionData
    {
        #region Public properties



        /// <summary>
        /// Номер таблицы
        /// </summary>
        /// <value>Число</value>
        int Table { get; set; }

        /// <summary>
        /// Номер ряда
        /// </summary>
        /// <value>Число</value>
        int Row { get; set; }

        /// <summary>
        /// Номер поля
        /// </summary>
        /// <value>Число</value>
        int Cell { get; set; }



        #endregion
    }
}
