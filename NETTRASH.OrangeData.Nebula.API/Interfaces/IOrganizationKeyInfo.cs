namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IOrganizationKeyInfo : IOrganizationKeyData
    {
        #region Public properties



        /// <summary>
        /// Идентификатор ключа
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        string Id { get; set; }

        /// <summary>
        /// Дата добавления ключа в БД. Проставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string CreateDate { get; set; }



        #endregion
    }
}
