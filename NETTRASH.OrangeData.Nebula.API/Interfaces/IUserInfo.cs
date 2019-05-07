namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IUserInfo : IUserBase
    {
        #region Public properties



        /// <summary>
        /// Время добавления пользователя в БД. Проставляется сервером автоматически
        /// </summary>
        /// <value>Время в виде строки в формате ISO8601, необязательное поле</value>
        string CreateDate { get; set; }



        #endregion
    }
}
