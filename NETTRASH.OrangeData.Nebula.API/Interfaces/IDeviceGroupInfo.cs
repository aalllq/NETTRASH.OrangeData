namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceGroupInfo : IDeviceGroupData
    {
        #region Public properties



        /// <summary>
        /// Дата добавления группы устройств в БД Проставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string CreateDate { get; set; }

        /// <summary>
        /// Количество неотправленных чеков в очереди
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? QueueCount { get; set; }



        #endregion
    }
}
