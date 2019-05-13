namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceInfo
    {
        #region Public properties



        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        string Id { get; set; }

        /// <summary>
        /// Идентификатор группы, к которой привязано устройство
        /// </summary>
        /// <value>Строка от 1 до 32 символов, необязательное поле</value>
        string DeviceGroupId { get; set; }

        /// <summary>
        /// Название группы, к которой привязано устройство
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string DeviceGroupName { get; set; }

        /// <summary>
        /// Идентификатор организации, к которой привязано устройство
        /// </summary>
        /// <value>Строка от 1 до 32 символов, необязательное поле</value>
        string OrganizationId { get; set; }

        /// <summary>
        /// Название организации, к которой привязано устройство
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string OrganizationName { get; set; }

        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        /// <value>Строка до 20 символов</value>
        string SerialNumber { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «true» – устройство заблокировано;
        ///   «false» - устройство активно
        /// </summary>
        /// <value>Логический</value>
        bool IsBlocked { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Comment { get; set; }

        /// <summary>
        /// Текущее состояние
        /// </summary>
        /// <value>Структура</value>
        IDeviceStateInfo State { get; set; }

        /// <summary>
        /// Автоматическое закрытие смены, се-кунды от начала дня, либо «null», тогда смена будет закрываться по исте-чению 24 часов
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? AutoCloseShiftAt { get; set; }



        #endregion
    }
}
