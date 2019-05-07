namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IClientData
    {
        #region Public properties



        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        string Id { get; set; }

        /// <summary>
        /// Идентификатор организации
        /// </summary>
        /// <value>Строка</value>
        string OrganizationId { get; set; }

        /// <summary>
        /// Уникальное имя клиента
        /// </summary>
        /// <value>Строка до 64 символов</value>
        string Name { get; set; }

        /// <summary>
        /// X.509 сертификат в формате Base-64
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Certificate { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «true» – агент заблокирован;
        ///   «false» - агент активен
        /// </summary>
        /// <value>Логический</value>
        bool IsBlocked { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Comment { get; set; }



        #endregion
    }
}
