using System;
namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IOrganizationInfo : IOrganizationData
    {
        #region Public properties



        /// <summary>
        /// Дата добавления организации в БД Про-ставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string CreateDate { get; set; }

        /// <summary>
        /// Количество неотправленных чеков в очереди
        /// </summary>
        /// <value>число, необяза-тельное поле</value>
        int? QueueCount { get; set; }

        /// <summary>
        /// Наличие в организации устройств с ошибками
        /// </summary>
        /// <value>логическоеl, необязательное поле</value>
        bool? HasDevicesWithErrors { get; set; }



        #endregion
    }
}
