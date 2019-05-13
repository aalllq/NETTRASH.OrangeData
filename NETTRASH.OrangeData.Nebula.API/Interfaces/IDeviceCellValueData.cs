namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceCellValueData : IDeviceCellPositionData
    {
        #region Public properties



        /// <summary>
        /// Данные ячейки таблицы устройства
        /// </summary>
        /// <value>Строка</value>
        string Value { get; set; }



        #endregion
    }
}
