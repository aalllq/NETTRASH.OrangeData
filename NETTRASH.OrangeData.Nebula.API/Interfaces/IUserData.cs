namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IUserData : IUserBase
    {
        #region Public properties



        /// <summary>
        /// Пароль
        /// </summary>
        /// <value>Строка до 6 символов</value>
        string Password { get; set; }



        #endregion
    }
}
