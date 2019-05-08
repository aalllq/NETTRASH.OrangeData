namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceChangeData
    {
        #region Public properties



        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        string Id { get; set; }

        /// <summary>
        /// Идентификатор группы устройств
        /// </summary>
        /// <value>Строка от 1 до 32 символов, необязательное поле</value>
        string DeviceGroupId { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «false» - устройство активно;
        ///   «true» - устройствозаблокировано
        /// </summary>
        /// <value>Логическое</value>
        bool IsBlocked { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Comment { get; set; }

        /// <summary>
        /// Автоматическое закрытие смены, секунды от начала дня, либо «null», тогда смена будет закрываться по истечению 24 часов
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? AutoCloseShiftAt { get; set; }



        #endregion
    }
}
