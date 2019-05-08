namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IToken
    {
        #region Public properties



        /// <summary>
        /// Токен доступа к API администрирования
        /// </summary>
        /// <value>Строка</value>
        string Data { get; set; }

        /// <summary>
        /// Дата протухания токена
        /// </summary>
        /// <value>Число</value>
        uint Expires { get; set; }



        #endregion
    }
}
