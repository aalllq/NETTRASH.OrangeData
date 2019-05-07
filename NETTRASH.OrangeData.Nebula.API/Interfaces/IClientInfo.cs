namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IClientInfo : IClientData
    {
        #region Public properties



        /// <summary>
        /// Дата добавления организации в БД. Проставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string CreateDate { get; set; }

        /// <summary>
        /// Отпечаток сертификата клиента
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Thumbprint { get; set; }

        /// <summary>
        /// Кому выдан сертификат клиента
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Subject { get; set; }

        /// <summary>
        /// Издатель сертификата клиента
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Issuer { get; set; }

        /// <summary>
        /// Начало действия сертификата клиента
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string ValidFrom { get; set; }

        /// <summary>
        /// Окончание действия сертификата клиента
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string ValidTo { get; set; }



        #endregion
    }
}
